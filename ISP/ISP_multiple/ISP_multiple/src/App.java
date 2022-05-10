public class App {
    public static void main(String[] args) throws Exception {
       
        PasswordProtector myProtector = new PasswordProtector();
        ProtectedDoor mydoor = new ProtectedDoor();
        
        mydoor.setMyProtector(myProtector); //initializing the protector for the newly created door
        
        myProtector.Register(1010, mydoor);
        mydoor.lock();

        mydoor.unlock();
        
    }
}
