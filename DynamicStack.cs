using System;

// dynamic array code with indexor

namespace Examples{

    public class Array{

        public static void Resize<T>(ref T[] source,int reSize){

            T[] temp =new T[reSize];
            for(int i=0;i<source.Length;i++){

                temp[i]=source[i];
            }
            source=temp;
        }
    }

    public class DynamicArray<T>{

        private T[] buffer = new T[5];
		private int itemCnt;
		
	public T this[int index]
	{
		set
			{
				itemCnt++;
				if (index >= buffer.Length){
				Array.Resize(ref buffer, index + 10);
                }
                buffer[index] = value;
			}
	   get
			{
				return buffer[index];
			}
	}
        
       
        public void Clear(){}
		
		public int ItemsCnt
		{
			get{
				return itemCnt;
			}
		}
		
		public int Capacity
		{
			get{
				return buffer.Length;
			}
		}

    }

    public class Program{

    public static  void Main(){

        DynamicArray<int> _Array=new DynamicArray<int>();
       // _intArray.<Set_Item(0,10); // _intArray[0]=10;
       
		
		_Array[0] = 10;
		_Array[1] = 20;
		_Array[2] = 30;
		_Array[3] = 40;
		_Array[4] = 50;
		_Array[5] = 60;
		_Array[6] = 70;
		_Array[7] = 80;
		_Array[8] = 90;
		_Array[9] = 100;
		
		 DynamicArray<char> _Array2 = new DynamicArray<char>();
       // _intArray.<Set_Item(0,10); // _intArray[0]=10;
       
		
		_Array2[0] = 'a';
		_Array2[1] = 'b';

        int _value=_Array[8];
      //  int _value=_intArray.Get_Item(8);
        Console.WriteLine(_value);
        Console.WriteLine(_Array.ItemsCnt);
        Console.WriteLine(_Array.Capacity);
		
		char _val2 = _Array2[1];
		Console.WriteLine(_val2);
		Console.WriteLine(_Array2.ItemsCnt);
        Console.WriteLine(_Array2.Capacity);
    }

    }
 
}
