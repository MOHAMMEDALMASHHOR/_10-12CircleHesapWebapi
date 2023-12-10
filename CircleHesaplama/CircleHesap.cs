namespace CircleHesaplama;

public class CircleHesap
{
    public decimal ClaculateCircumference(int r){
        return (decimal)(r * 2*Math.PI);
    }
    public decimal ClaculateCircleArea(int r){
        return (decimal)(r *r*Math.PI);
    }
}
