public class App {
    public static void main(String[] args) throws Exception {
      
      PasswordProtector protector = new PasswordProtector(); 
      ProtectedDoor door = new ProtectedDoor(protector); 
      
      //registering the door's password
      protector.Register(1010, door.getDoorPasswordAdapter()); 
      door.lock();
      door.unlock();
      door.checkAlarm();  
      
    }
}
