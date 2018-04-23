using System;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;

namespace InstantEditing {
    /// <summary>
    /// Summary description for XpoHelper
    /// </summary>
    public static class XpoHelper {
        static XpoHelper() {
            CreateDefaultObjects();
        }

        public static Session GetNewSession() {
            return new Session(DataLayer);
        }

        public static UnitOfWork GetNewUnitOfWork() {
            return new UnitOfWork(DataLayer);
        }

        private readonly static object lockObject = new object();

        static IDataLayer fDataLayer;
        static IDataLayer DataLayer {
            get {
                if(fDataLayer == null) {
                    lock(lockObject) {
                        fDataLayer = GetDataLayer();
                    }
                }
                return fDataLayer;
            }
        }

        private static IDataLayer GetDataLayer() {
            XpoDefault.Session = null;

            InMemoryDataStore provider = new InMemoryDataStore();
            IDataLayer dl = new SimpleDataLayer(provider);

            return dl;
        }

        private static void CreateDefaultObjects() {
            using(UnitOfWork uow = GetNewUnitOfWork()) {
                Model model = new Model(uow);
                model.Name = "SD970 IS";
                model.Price = 379.99m;
                model.Discontinued = false;
                model.Announced = new DateTime(2009, 2, 18);

                model = new Model(uow);
                model.Name = "G10";
                model.Price = 419.99m;
                model.Discontinued = false;
                model.Announced = new DateTime(2008, 9, 17);

                model = new Model(uow);
                model.Name = "A580";
                model.Price = 118.00m;
                model.Discontinued = false;
                model.Announced = new DateTime(2008, 1, 24);

                model = new Model(uow);
                model.Name = "EOS D30";
                model.Price = 275.00m;
                model.Discontinued = true;
                model.Announced = new DateTime(2000, 5, 17);

                uow.CommitChanges();
            }
        }
    }
}