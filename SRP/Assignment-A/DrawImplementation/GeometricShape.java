public class GeometricShape {

    private Shape myShape;

    public GeometricShape(Shape _shape) {
        myShape = _shape;
    }
    
    public double getXLowerRightCorner(){
        return  myShape.getxUpperLeftCornet() + myShape.getWidth1();
    }

    public double getYLowerRightCorner(){
        return  myShape.getyUpperLeftCorner() + myShape.getHeight1();
    }

}
