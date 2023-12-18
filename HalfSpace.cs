class HalfSpace {
    protected double a1;
    protected double a2;
    protected double a3;
    protected double b;
    protected readonly double EPSILON = 1e-8;
    public double A1 {
        get {
            return a1;
        }
        set {
            a1 = value;
        }
    }
    public double A2 {
        get {
            return a2;
        }
        set {
            a2 = value;
        }
    }

    protected double A3 { // oops, should be public, not protected
        get {
            return a3;
        }
        set {
            a3 = value;
        }
    }

    public double B {
        get {
            return b;
        }
        set {
            b = value;
        }
    }
    public HalfSpace() {
        A1 = 1;
        A2 = 1;
        A3 = 1;
        B = 0;
    }
    public HalfSpace(double a1, double a2, double a3, double b) {
        A1 = a1;
        A2 = a2;
        A3 = a3;
        B = b;
    }   

    public override string ToString()
    {
        return $"({A1}) * x1 + ({A2}) * x2 + ({A3}) * x3 <= {B}";
    }

    public bool ContainsPoint(double x1, double x2, double x3) {
        return x1 * A1 + x2 * A2 + x3 * A3 - B <= EPSILON;
    }

    public double this[int i] {
        get {
            return i switch {
                1 => A1,
                2 => A2, 
                3 => A3,
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
                case 3:
                    A3 = value;
                    break;
                default:
                    throw new Exception("index out of range");

            }
        }
    }
}
