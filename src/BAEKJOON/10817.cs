/*세 정수 A, B, C가 주어진다. 이때, 두 번째로 큰 정수를 출력하는 프로그램을 작성하시오. 
첫째 줄에 세 정수 A, B, C가 공백으로 구분되어 주어진다. (1 ≤ A, B, C ≤ 100)*/
using System;

public class B10817{
	public static void main(){
		string s = Console.ReadLine();
		string[] ss = s.Split();
		
		int a = int.Parse(ss[0]);
		int b = int.Parse(ss[1]);
		int c = int.Parse(ss[2]);
		
		if((a<=b && a>=c)||(a<=c && a>=b)){
			Console.WriteLine(a);
		}
		else if((b<=a && b>=c)||(b<=c && b>=a)){
			Console.WriteLine(b);
		}
		else if((c<=a && c>=b)||(c<=b && c>=a)){
			Console.WriteLine(c);
		}
	}
}