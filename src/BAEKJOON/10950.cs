/*두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
첫째 줄에 테스트 케이스의 개수 T가 주어진다.

각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)*/

using System;

public class B10950{
	public static void main(String[] args){
		
		string s = Console.ReadLine();
		int s1 = int.Parse(s);
		
		for(int i=0; i<s1; i++){
			string t = Console.ReadLine();
			string[] tt = t.Split();
			
			int a = int.Parse(tt[0]);
			int b = int.Parse(tt[1]);
			
			Console.WriteLine(a+b);
		}

	}
}