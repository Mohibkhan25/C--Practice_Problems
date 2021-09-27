using System;
 
public class NotificationManager{

    //EmailNotificationSystem _emailNotificationSystem=new EmailNotificationSystem();
    //SMSDeliverySystem _smsDeliverySystem=new SMSDeliverySystem();
    Action observers;

    public void Register(Action observer){
        observers+=observer;
    }
    public void UnRegister(Action observer){
        observers-=observer;
    }
    public void Notify(){
        //Console.WriteLine();
        this.observers.Invoke();
    }

}
//Observable
public class SpeedGovernor{
	
	int threasold = 100;
    NotificationManager _notifyManager;
    public SpeedGovernor(NotificationManager notificationManager){

        this._notifyManager=notificationManager;
    }
   public void CheckThreasoldSpeed(int speed){
	   if(speed > threasold){
		   this.Notify();
	   }
	   else{
		   Console.WriteLine("You are driving safely.");
	   }
   }
    void Notify(){
        _notifyManager.Notify();
    }

}
 
public class IVRS{
    public void TextToSpeech(){
    Console.WriteLine("TextToSpeech : Please slow down your car!! yo have exeeded the Theasold speed." );
    }
    public void Update(){
        TextToSpeech();
    }
}
 
public class SpeedController{
    public void LockVehicleSpeed(){
    Console.WriteLine("LockVehicleSpeed : The car speed has been locked, Can't exeed the theasold" );
    }
    public void Update(){
        LockVehicleSpeed();
    }   
}

public class MessageSystem{
    public void SendMessageToCallCenter(){
    Console.WriteLine("MessageSystem : Send to call center" );
    }
    public void Update(){
        SendMessageToCallCenter();
    }   
}


public class Program
{
    public static void Main()
    {
        //Console.WriteLine("Hello World");
        //EmailNotificationSystem _emailNS=new EmailNotificationSystem();
       // SMSDeliverySystem _smsNs=new SMSDeliverySystem();
		
		IVRS _ivrsObj = new IVRS();
		SpeedController _speedControllerObj = new SpeedController();
		MessageSystem _messageSystemObj = new MessageSystem();

        Action _observer1 = new Action(_ivrsObj.Update);
		Action _observer2 = new Action(_speedControllerObj.Update);
		Action _observer3 =new Action(_messageSystemObj.Update);
        

        NotificationManager _notificationManager=new  NotificationManager();
        _notificationManager.Register (_observer1);
        _notificationManager.Register (_observer2);
		_notificationManager.Register (_observer3);

        SpeedGovernor _speedGovernerObj = new  SpeedGovernor(_notificationManager);
        _speedGovernerObj.CheckThreasoldSpeed(120);
        System.Threading.Tasks.Task.Delay(2000).Wait();
        /*_appointment.Confirm();
        System.Threading.Tasks.Task.Delay(2000).Wait();
        _appointment.Cancel();*/

    }
}
