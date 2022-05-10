public class PasswordProtector {
    private int safeNumber;
    private PasswordClient myclient;
    
    public void Register(int code, PasswordClient client){
        safeNumber = code;
        myclient = client;       
    }

    public void check(int code){
        if(code !=safeNumber)
            myclient.setAlarmStatus(true);	
        else
           myclient.setAlarmStatus(false);   
    }

}
