#include <iostream>
#include <cstring>

using namespace std;

//int main() {
//	const int size = 15;
//	char name1[size];
//	char name2[size] = "C++programping";
//
//	cout << "�ȳ��ϼ���" << name2 << endl;
//
//	//���ڿ� �޾Ƽ� �����ȿ� ����
//	//������ ������ ���ڿ��� �����ٰ� �����ϰ� ����
//	//cin >> name1;
//
//	//��������
//	cin.getline(name1, size);
//
//	cout << " ���� " << name1 << endl << "�Դϴ�.";
//
//	cout << "�̸��� " << strlen(name1) << "�� �̱���" << endl;
//
//	//C++ ���
//	name2[3] = '\0';
//
//	cout << name2 <<endl ;
//
//	//C++���� ���ڿ��� �ٷ�� ����� �ϳ��� string
//	//c ��Ÿ�Ϸ� string ��ü�� �ʱ�ȭ �� �� �ִ�.
//
//	string str1;
//	string str2 = "panda";
//	
//	//����ü : �ٸ� ���������� ���Ǵ� �������� ����
//	//�迭 : ���� ���������� ����
//
//	//�౸ ����
//	struct player
//	{
//		string name;
//		string position;
//		int height;
//		int weight;
//	};
//
//	//����ü���� ���� �ȵ� ���� 0
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
//	//����ü �迭 ����
//	player A[2]{
//		{"A","A",1,1},
//		{"B","B",2,2}
//	};
//
//	cout <<"A�� Ű�� " << A[0].height << endl;
//
//	//����ü(union) : ���δٸ� ���������� �ѹ��� ������ �� ����
//	//����ü : ��ȣ ����� ����� �Ϳ� ���� �Ǵٸ� ���
//
//	// spectrum�� ���ο� �������� �̸����� ����ϴ�.
//	// red, orange ,,, 0���� ���� 7���� ���� ���� ���� ��Ÿ���� ��ȣ ����� ����ϴ�.
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