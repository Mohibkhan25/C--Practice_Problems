[Yesterday 10:49 AM] venu (Guest)
    
using System;
                    
public class SearchWindow{​​​​​


    Button _clearButton=new Button();
    TextBox _searchBox=new TextBox();
    public void SimulateClearButtonClick(){​​​​​
        _clearButton.OnClick();
    }​​​​​
}​​​​​
public class Button{​​​​​
    
    //Event  Click
    
    public void OnClick(){​​​​​
    
        //
        Console.writeLine("Text cleared!!");
    }​​​​​
}​​​​​
public class TextBox{​​​​​


    public void Clear(){​​​​​
        Console.WriteLine("TextBox Content Cleared");
    }​​​​​
}​​​​​
public class Program
{​​​​​
    public static void Main()
    {​​​​​
        SearchWindow _searchWindow=new SearchWindow();
        while(true){​​​​​
            Console.WriteLine("Press Any Key To Click Clear Button");
            System.Threading.Tasks.Task.Delay(1000).Wait();
            _searchWindow.SimulateClearButtonClick();
        }​​​​​
    }​​​​​
}​​​​​




