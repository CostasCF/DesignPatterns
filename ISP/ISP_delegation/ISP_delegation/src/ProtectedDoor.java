import java.util.Scanner;

public class ProtectedDoor implements Door {
    private Boolean locked;
    private DoorPasswordAdapter myDoorPasswordAdapter;

    public void setDoorPasswordAdapter(DoorPasswordAdapter newDoorPasswordAdapter){
        myDoorPasswordAdapter = newDoorPasswordAdapter;
    }

    public DoorPasswordAdapter getDoorPasswordAdapter()
    {return myDoorPasswordAdapter;}
    
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
        locked =  myDoorPasswordAdapter.check(number);
       
        if(!locked){
            System.out.println("The door is unlocked.");
        }
        
    }
    
}
