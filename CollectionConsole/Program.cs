// See https://aka.ms/new-console-template for more information

int[] arr = { 1, 3, 5, 2, 6, 7 };

//사전 순
string[] s_arr = { "10", "32", "1","8" };

int[] i_int = Array.ConvertAll(s_arr, int.Parse);

//-붙이면 내림차순 기준 만들기
int[] arr3 = arr.OrderBy(i => i).ToArray();

Array.Sort(arr);
Array.Sort(s_arr);
/*Console.WriteLine("Sorted array: " + string.Join(", ", arr));
Console.WriteLine("Sorted array: " + string.Join(", ", s_arr));
Console.WriteLine("Sorted array: " + string.Join(", ", arr3));*/

string[] strArr = Array.ConvertAll(arr , x => x.ToString());

int[] intArr = { 3, 1, 2 };

//int[] intArr2 = Array.ConvertAll(intArr, x => (2 * x));

string[] strArr2 = Array.ConvertAll(intArr, x => (2*x).ToString());

Console.WriteLine("Sorted array: " + string.Join(", ", strArr2));

