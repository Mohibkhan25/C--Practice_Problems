using System;

public interface IEngine{
	void Start();
    void Stop();
}
 
public class DiCorEngine : IEngine{

    public void Start(){ Console.WriteLine("Dicor Engine Start!!"); }
    public void Stop(){ Console.WriteLine("Dicor Engine Stop!!"); }
}
 
public class VeriCorEngine : IEngine{
	
	public void Start(){ Console.WriteLine("VeriCorEngine Start!!"); }
    public void Stop(){ Console.WriteLine("VeriCorEngine Stop!!"); }
}
 
public class MultiJetEngine : IEngine{
	
	public void Start(){ Console.WriteLine("MultiJetEngine Start!!"); }
    public void Stop(){ Console.WriteLine("MultiJetEngine Stop!!"); }
}
public class RevorTron : IEngine{ 
	
	public void Start(){ Console.WriteLine("RevorTron Start!!"); }
    public void Stop(){ Console.WriteLine("RevorTron Stop!!"); }
}

public class TATACar{
    IEngine _engine;
	
    public TATACar(IEngine engine){

        _engine = engine;
    }

    public void Drive(){

        _engine.Start();
    }
    public void Halt(){

        _engine.Stop();
    }
 
}
 
//BS IV 
 
//BS VI
 

public class Program
{
    public static void Main()
    {
		IEngine _engine = new DiCorEngine();
		IEngine _engine2 = new VeriCorEngine();
        TATACar _harrier=new TATACar(_engine);
		_harrier.Drive();
		_harrier.Halt();
        TATACar _nexon=new TATACar(_engine2);
		_nexon.Drive();
		_nexon.Halt();
        TATACar _hexa=new TATACar(_engine); 
    }
}
