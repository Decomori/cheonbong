/*첫 줄에 테스트케이스의 개수 T가 주어진다. T는 최대 1,000,000이다. 다음 T줄에는 각각 두 정수 A와 B가 주어진다. A와 B는 1 이상, 1,000 이하이다.
	시간제한 - 1초
*/
using System;
using System.Text;

public class B15552{
	public static void main(String[] args){
		int count = int.Parse(Console.ReadLine().Trim());
		string s = Console.ReadLine();
		string[] ss = s.Split();
		
		int a = int.Parse(ss[0]);
		int b = int.Parse(ss[1]);
		
		for(int i=0; i<count; i++){
			Console.WriteLine(a+b);
		}
		int t = int.Parse(Console.ReadLine().Trim());
		StringBuilder sb = new StringBuilder();
		
			for (int i = 1; i <= t; i++)
            { 
                sb.AppendLine(i.ToString()); 
            } 
        Console.Write(sb.ToString());
	}
}