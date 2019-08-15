//n이 주어졌을 때, 1부터 n까지 합을 구하는 프로그램을 작성하시오.
using System;

public class B8393{
	public static void Main(String[] args){
		string s = Console.ReadLine();
		int a = int.Parse(s);
		int sum = 0;
		
		for(int i=1; i<=a; i++){
			sum += i;
		}
		Console.WriteLine(sum);
	}
}