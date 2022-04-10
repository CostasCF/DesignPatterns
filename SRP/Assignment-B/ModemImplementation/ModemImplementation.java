public class ModemImplementation implements DataChannel,Connection {

    private char chr;

    public char getChar(){
        return chr;
    }

    public void setChar(char c){
         chr = c; 
    }

    public void dial() {
        System.out.println("Modem succussfully connected!");
        
    }

    
    public void hungup() {
        System.out.println("Connection Closed");
        
    }

   
    public void send(char c) {
        setChar(c);
        System.out.println("Sending packet..: " + getChar() );
        
    }

    public void recv() {
        if((int)chr==0 ){
            System.out.println("chr is null, error.");
        }else{
            System.out.println("Received packet succssfully.");
            System.out.println("Packet received: " + getChar() );
        }
    }  
}
