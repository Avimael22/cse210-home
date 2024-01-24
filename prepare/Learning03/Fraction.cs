using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

public class Fraction{
    private int _top = 0;
    private int _bottom = 0;
    
    public Fraction(){

    }
    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom){
        SetFractionValues(top, bottom);
    }

    public void SetFractionValues(int up, int down){
        _top = up;
        _bottom = down;
    }

    public string GetFractionString(){
        string fraction = _top.ToString()+"/"+_bottom.ToString();
        return fraction;
    }

    public double GetDecimalValue(){
        double fracion = (double)_top/_bottom;
        return fracion;
    }
}