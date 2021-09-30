using System;
using System.Collections.Generic;

public abstract class vehicle{}

public class Engine{}

public class Transmission{}
					
public class car : vehicle
{
	Engine _engObj = new Engine();
	Transmission _trnObj = new Transmission();
}

public abstract class Document{
	List<Pages> _pageObj = new List<Pages>();
}

public class Header{}

public class Footer{}

public class Margin {}

public class Paragrams {}

public class Pages{
	Header _headObj = new Header();
	Footer _footObj = new Footer();
	Margin _marObj = new Margin();
	Paragrams _parObj = new Paragrams();

}

public class MSWord : Document {
	List<Pages> _pageObj = new List<Pages>();
}





