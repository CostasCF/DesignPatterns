public class App {
    public static void main(String[] args) throws Exception {
      PasswordProtector protector = new PasswordProtector(); //creating a new object of PasswordProtector
      ProtectedDoor door = new ProtectedDoor(); //creating a new object of Door
      DoorPasswordAdapter doorPasswordAdapter = new DoorPasswordAdapter(protector); // creating a new DoorPasswordAdapter and passing as parameter the newly created object of PasswordProtector
      door.setDoorPasswordAdapter(doorPasswordAdapter); //"linking" the door created above with the newly created DoorPasswordAdapter
      protector.Register(1010, door.getDoorPasswordAdapter()); //registering the door for the first time
      door.lock();
      door.unlock();
      door.checkAlarm();  
    }
}
