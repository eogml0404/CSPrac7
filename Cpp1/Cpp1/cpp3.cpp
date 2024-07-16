#include <iostream>
#include <cstring>

using namespace std;
//int main() {
//	//변수 선언 과정
//
//	//값 저장
//	int val = 3;
//
//	//주소 표현
//	cout << &val << endl;
//	
//	//C++ 객체지향 프로그래밍
//	/*
//	컴파일 시간이 아닌 실행 시간에 어떠한 결정을 내릴 수 있다.
//	
//	ex ) 배열생성
//	절차적 프로그래밍 : 배열의 크기가 미리 결정
//	객체지향 프로그래밍 : 배열의 크기를 실행시간에 결정
//
//	*/
//
//	//포인터 : 사용할 주소에 이름을 붙인다.
//	//즉, 포인터는 포인터의 이름이 주소를 나타낸다.
//	//간접값 연산자, 간접 참조 연산자 *
//
//	//int* a;  C 스타일
//	//int* b;  C++ 스타일
//	//int* c, d; C는 포인터 변수, d는 int형 변수
//	
//	int a = 6; //값
//	int* b; //위치
//	b = &a;
//	
//	cout << "a의 값" << a << endl;
//	cout << "*b의 값" << *b << endl;
//
//	cout << "a의 주소" << &a << endl;
//	cout << "*b의 주소" << b << endl;
//
//	*b = *b + 1;
//
//	cout << "이제 a의 값은" << a << endl;
//
//	//new 연산자
//	
//	/*
//	어떤 데이터형을 원하는지 new 연산자에게 알려주면 new 연산자는 그에 알맞은 크기에 메모리 블록을
//	찾아내고 그 블록의 주소를 리턴합니다
//	*/
//	/*
//	delete 연산자 사용한 메모리를 다시 메모리 풀로 환수
//	1. new로 대입하지 않은 메모리는 delete로 해제할 수 없다.
//	2. 같은 메모리 블록을 연달아 delete 불가
//
//	*/
//
//	/*int* ps = new int;
//
//	delete ps;*/
//
//	double* p3 = new double[3];
//	p3[0] = 0.2;
//	p3[1] = 0.5;
//	p3[2] = 0.8;
//
//	// p3[0] -> p3[1] , p3[1] -> p3[2] 
//	// 포인터를 증가 시킨다
//	p3 = p3 + 1;
//
//	cout << "Now p3[1] = " << p3[1] << endl;
//
//	const int Size = 20;
//	//포인터의 문자열
//	char animal2[Size];
//	char* ps;
//
//	cout << "동물의 이름을 입력하세요";
//	cin >> animal2;
//
//	//한칸더 넉넉하게 잡음 (메모리에서 유리하다)
//	ps = new char[strlen(animal2) + 1];
//	
//	//ps에 그 값 복사
//	strcpy(ps, animal2);
//
//	//복사하면 주소가 다르고 value는 같음
//
//	
//	//동적 구조체 생성 
//
//	struct MyStruct {
//		char name[20];
//		int age;
//	};
//
//	MyStruct* temp = new MyStruct;
//
//	cout << "당신의 이름을 입력하세요\n";
//
//	// ->를 이용하면 동적구조체에 접근가능 혹은 *(temp).name
//	cin >> temp->name;
//
//	return 0;
//}