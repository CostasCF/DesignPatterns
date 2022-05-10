public class DoorPasswordAdapter implements PasswordClient{

    private PasswordProtector myProtector;
    private boolean isActive;

    public boolean getAlarmStatus(){return isActive;}
    public void setAlarmStatus(boolean status){
        isActive= status;
    }

    public DoorPasswordAdapter(PasswordProtector aPasswordProtector){
        myProtector = aPasswordProtector;
    }


    public void setMyProtector(PasswordProtector theProtector) {
        myProtector = theProtector;
        
    }

    public void check(int number) {
        myProtector.check(number);
    }

}