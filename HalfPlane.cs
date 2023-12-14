using System.ComponentModel;
class HalfPlane : HalfSpace {
    public HalfPlane(double a1, double a2, double b) : base(a1, a2, 0, b) {
    }

    public HalfPlane() : this(1, 1, 0) {
    }

    public bool ContainsPoint(double x1, double x2) {
        return x1 * A1 + x2 * A2 - B <= EPSILON;
    }

    public override string ToString()
    {
        return $"({A1}) * x1 + ({A2}) * x2 <= {B}";
    }

    public void Print() {
        Console.WriteLine(this);
    }
    
    public new double this[int i] {
        get {
            return i switch {
                1 => A1,
                2 => A2, 
                _ => throw new Exception("index out of range"),
            };
        } 
        set {
            switch (i) {
                case 1:
                    A1 = value;
                    break;
                case 2:
                    A2 = value;
                    break;
                default:
                    throw new Exception("index out of range");

            }
        }
    }


}