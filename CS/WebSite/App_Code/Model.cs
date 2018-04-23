using System;
using DevExpress.Xpo;

public class Model : XPObject {
    public Model(Session session) : base(session) { }

    private string _Name;
    public string Name {
        get {
            return _Name;
        }
        set {
            SetPropertyValue("Name", ref _Name, value);
        }
    }
    private decimal _Price;
    public decimal Price {
        get {
            return _Price;
        }
        set {
            SetPropertyValue("Price", ref _Price, value);
        }
    }
    private DateTime _Announced;
    public DateTime Announced {
        get {
            return _Announced;
        }
        set {
            SetPropertyValue("Announced", ref _Announced, value);
        }
    }
    private bool _Discontinued;
    public bool Discontinued {
        get {
            return _Discontinued;
        }
        set {
            SetPropertyValue("Discontinued", ref _Discontinued, value);
        }
    }
}