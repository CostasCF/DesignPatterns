public class App {
    public static void main(String[] args) throws Exception {
      
      PasswordProtector protector = new PasswordProtector(); //creating a new object of PasswordProtector
      ProtectedDoor door = new ProtectedDoor(protector); //creating a new object of Door

      protector.Register(1010, door.getDoorPasswordAdapter()); //registering the door for the first time
      door.lock();
      door.unlock();
      door.checkAlarm();  
      
    }
}
