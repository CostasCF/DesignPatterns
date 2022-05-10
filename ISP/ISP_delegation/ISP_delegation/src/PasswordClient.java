public interface PasswordClient {
   public boolean getAlarmStatus();
   public void setAlarmStatus(boolean status);
   public void setMyProtector(PasswordProtector theProtector);
}
