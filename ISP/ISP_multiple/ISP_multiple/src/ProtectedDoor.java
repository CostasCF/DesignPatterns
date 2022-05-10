import java.util.Scanner;

public class ProtectedDoor implements Door,PasswordClient {
    private PasswordProtector myProtector;
    private Boolean locked;
    
    @Override
    public void lock() {
        locked = true;
        System.out.println("The door is locked.");
    }

    @Override
    public void unlock() {
        int number;
        System.out.println("Enter code: ");
        Scanner myObj = new Scanner(System.in);
        number = myObj.nextInt();
        myObj.close();
        locked = myProtector.check(number);
        if(!locked){
            System.out.println("The door is unlocked.");
        }
    }

    @Override
    public void alarm() {
      System.out.println("ALARM: Someone is trying to enter without code!!\n");
        
    }

    @Override
    public void setMyProtector(PasswordProtector theProtector) {
        myProtector = theProtector;
        
    }
    
}
