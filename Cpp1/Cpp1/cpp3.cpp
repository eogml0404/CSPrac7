#include <iostream>
#include <cstring>

using namespace std;
//int main() {
//	//���� ���� ����
//
//	//�� ����
//	int val = 3;
//
//	//�ּ� ǥ��
//	cout << &val << endl;
//	
//	//C++ ��ü���� ���α׷���
//	/*
//	������ �ð��� �ƴ� ���� �ð��� ��� ������ ���� �� �ִ�.
//	
//	ex ) �迭����
//	������ ���α׷��� : �迭�� ũ�Ⱑ �̸� ����
//	��ü���� ���α׷��� : �迭�� ũ�⸦ ����ð��� ����
//
//	*/
//
//	//������ : ����� �ּҿ� �̸��� ���δ�.
//	//��, �����ʹ� �������� �̸��� �ּҸ� ��Ÿ����.
//	//������ ������, ���� ���� ������ *
//
//	//int* a;  C ��Ÿ��
//	//int* b;  C++ ��Ÿ��
//	//int* c, d; C�� ������ ����, d�� int�� ����
//	
//	int a = 6; //��
//	int* b; //��ġ
//	b = &a;
//	
//	cout << "a�� ��" << a << endl;
//	cout << "*b�� ��" << *b << endl;
//
//	cout << "a�� �ּ�" << &a << endl;
//	cout << "*b�� �ּ�" << b << endl;
//
//	*b = *b + 1;
//
//	cout << "���� a�� ����" << a << endl;
//
//	//new ������
//	
//	/*
//	� ���������� ���ϴ��� new �����ڿ��� �˷��ָ� new �����ڴ� �׿� �˸��� ũ�⿡ �޸� ������
//	ã�Ƴ��� �� ������ �ּҸ� �����մϴ�
//	*/
//	/*
//	delete ������ ����� �޸𸮸� �ٽ� �޸� Ǯ�� ȯ��
//	1. new�� �������� ���� �޸𸮴� delete�� ������ �� ����.
//	2. ���� �޸� ������ ���޾� delete �Ұ�
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
//	// �����͸� ���� ��Ų��
//	p3 = p3 + 1;
//
//	cout << "Now p3[1] = " << p3[1] << endl;
//
//	const int Size = 20;
//	//�������� ���ڿ�
//	char animal2[Size];
//	char* ps;
//
//	cout << "������ �̸��� �Է��ϼ���";
//	cin >> animal2;
//
//	//��ĭ�� �˳��ϰ� ���� (�޸𸮿��� �����ϴ�)
//	ps = new char[strlen(animal2) + 1];
//	
//	//ps�� �� �� ����
//	strcpy(ps, animal2);
//
//	//�����ϸ� �ּҰ� �ٸ��� value�� ����
//
//	
//	//���� ����ü ���� 
//
//	struct MyStruct {
//		char name[20];
//		int age;
//	};
//
//	MyStruct* temp = new MyStruct;
//
//	cout << "����� �̸��� �Է��ϼ���\n";
//
//	// ->�� �̿��ϸ� ��������ü�� ���ٰ��� Ȥ�� *(temp).name
//	cin >> temp->name;
//
//	return 0;
//}