public class Delegate{

    public static Func<string, string> reverseStringDelegate = x => new string(x.Reverse().ToArray());

    public static Func<double, double, double> productDoubleDelegate = (d1,d2) => d1*d2;

    public static Func <int, string, bool> equalBoolDelegate = (i,x) => {
        x = x.TrimStart('0');
        int c = Int32.Parse(x);
        return i == c;
        };
}