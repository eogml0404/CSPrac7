#include <iostream>
#include <cstring>

using namespace std;

//int main() {
//	const int size = 15;
//	char name1[size];
//	char name2[size] = "C++programping";
//
//	cout << "안녕하세요" << name2 << endl;
//
//	//문자열 받아서 변수안에 넣음
//	//공백을 만나면 문자열이 끝났다고 생각하고 끝남
//	//cin >> name1;
//
//	//공백포함
//	cin.getline(name1, size);
//
//	cout << " 저는 " << name1 << endl << "입니다.";
//
//	cout << "이름은 " << strlen(name1) << "자 이군요" << endl;
//
//	//C++ 출력
//	name2[3] = '\0';
//
//	cout << name2 <<endl ;
//
//	//C++에서 문자열을 다루는 방법중 하나인 string
//	//c 스타일로 string 객체를 초기화 할 수 있다.
//
//	string str1;
//	string str2 = "panda";
//	
//	//구조체 : 다른 데이터형이 허용되는 데이터의 집합
//	//배열 : 같은 데이터형의 집합
//
//	//축구 선수
//	struct player
//	{
//		string name;
//		string position;
//		int height;
//		int weight;
//	};
//
//	//구조체에서 정의 안된 값은 0
//	player B{
//		"yoon",
//		"striker",
//		182,
//		70
//	};
//
//	player p;
//	p.name = "Son";
//	p.position = "Striker";
//	p.height = 183;
//	p.weight = 70;
//
//	//구조체 배열 선언
//	player A[2]{
//		{"A","A",1,1},
//		{"B","B",2,2}
//	};
//
//	cout <<"A의 키는 " << A[0].height << endl;
//
//	//공용체(union) : 서로다른 데이터형을 한번에 저장할 수 있음
//	//열거체 : 기호 상수를 만드는 것에 대한 또다른 방법
//
//	// spectrum을 새로운 데이터형 이름으로 만듭니다.
//	// red, orange ,,, 0에서 부터 7까지 정수 값을 각각 나타내는 기호 상수로 만듭니다.
//	enum spectrum {red, orange, yellow, green, blue,violet, indigo, untraviolet};
//	spectrum a = orange;
//	cout << a << endl;
//	
//	int b;
//	b = blue;
//	b = blue + 3;
//
//	cout << b << endl;
//	return 0;
//}