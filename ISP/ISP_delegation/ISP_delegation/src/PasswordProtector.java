public class PasswordProtector {
    private int safeNumber;
    private PasswordClient myclient;
    
    public void Register(int code, PasswordClient client){
        safeNumber = code;
        myclient = client;       
    }

    public boolean check(int code){
        if(code !=safeNumber){
            myclient.alarm();
            return true; 
        } 	
        else
            return false;     
    }

}
