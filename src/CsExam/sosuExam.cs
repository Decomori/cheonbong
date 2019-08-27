using System;

public class soSuExam{
	public static void Main(String[] args){
		Console.WriteLine("어디까지 구해요?"); 

            int range = int.Parse(Console.ReadLine()); //범위 입력받음. 
            int count = 0; 

            int[] arr = new int[range]; 
            arr[0] = 1; 

            for (int i = 1; i<=range; i++) //입력받은 범위까지 연산 
            { 
                for (int j = 1; j <= i; j++) 
                { 
                    if ((i%j)==0) 
                    { 
                        count++; 
                    } 
                } 

                if(count==2) // 약수가 1과 자신뿐일때 
                { 
                    arr[i] = i; //배열에 저장 
                } 

                count = 0; 
            } 

            Console.Write("소수 : "); 

            for (int i = 0; i < arr.Length; i++) 
            { 
                if (arr[i] != 0) Console.Write(arr[i] + "."); 
            } 

            Console.Write("\n");
	}
}