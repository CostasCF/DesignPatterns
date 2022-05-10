import java.util.Scanner;


public class ProtectedDoor implements Door {
    private DoorPasswordAdapter myDoorPasswordAdapter;

    public void setDoorPasswordAdapter(DoorPasswordAdapter newDoorPasswordAdapter){
        myDoorPasswordAdapter = newDoorPasswordAdapter;
    }

    public DoorPasswordAdapter getDoorPasswordAdapter()
    {return myDoorPasswordAdapter;}
    
    public void checkAlarm() {
        if (myDoorPasswordAdapter.getAlarmStatus()) { 
                System.out.println("ALARM: Someone is trying to enter without code!!\n");
        }
     }

    @Override
    public void lock() {
        System.out.println("The door is locked.");
    }

    @Override
    public void unlock() {
        int number;
        System.out.println("Enter code: ");
        Scanner myObj = new Scanner(System.in);
        number = myObj.nextInt();
        myObj.close();
        myDoorPasswordAdapter.check(number);
        if(!myDoorPasswordAdapter.getAlarmStatus()){
            System.out.println("The door is unlocked.");
        }
        
    }
    
}
