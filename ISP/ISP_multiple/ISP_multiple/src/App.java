public class App {
    public static void main(String[] args) throws Exception {
       
        PasswordProtector myProtector = new PasswordProtector();
        ProtectedDoor mydoor = new ProtectedDoor();
        
        //initializing the protector for the newly created door
        mydoor.setMyProtector(myProtector); 
        
        //registering the door's password
        myProtector.Register(1010, mydoor);
        mydoor.lock();
        mydoor.unlock(); 
    }
}
