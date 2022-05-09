public class Main {
    public static void main(String[] args) {
        ModemImplementation modem = new ModemImplementation();
        modem.dial();
        modem.send((char) 3);
        modem.recv();
        modem.hungup();
    }
}
