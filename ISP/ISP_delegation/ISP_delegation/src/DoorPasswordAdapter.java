public class DoorPasswordAdapter implements PasswordClient{

    private PasswordProtector myProtector;

    public DoorPasswordAdapter(PasswordProtector aPasswordProtector){
        myProtector = aPasswordProtector;
    }

    public void alarm() {
        System.out.println("ALARM: Someone is trying to enter without code!!\n");
        
    }

    public void setMyProtector(PasswordProtector theProtector) {
        myProtector = theProtector;
        
    }

    public boolean check(int number) {
       return myProtector.check(number);
    }

}