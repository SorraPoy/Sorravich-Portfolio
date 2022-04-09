#include <iostream>
#include <conio.h>
#include <string>
using namespace std;

main(){
	int i,j,k,l,m,n,a,b,c,d,f,g,h;
	char o0,o2,o3;
	int o1;
	int AllSub,StuNo;
	string SubStu[50][50] = {};
	b=1;
	g=1;
	n=1;
	
	cout <<"How many subjects? (MAX = 50) : ";
	cin >> AllSub;
	
	for (i=0;i<AllSub;i++){
		++k;
		l=0;
		cout <<"Name of Subject : ";
		cin >> SubStu[k][l];
		cout <<endl;
	}

	cout <<"How many students? (MAX = 50) : ";
	cin >> StuNo;
		
	for(i=0;i<StuNo;i++){
		system("cls");
		++l;
		k=0;
		a=1;		
		c=0;
		d=0;
		cout <<"Name of Student : ";
		cin >> SubStu[k][l];
		cout <<endl;
		for(j=0;j<AllSub;j++){
			++c;
			cout <<"Has He(or She) enrolled in " <<SubStu[c][d]<<"? (Y or N) : ";
			cin >>o0;
			if(o0 == 'Y' || o0 == 'y'){
				SubStu[a][b] = "Y";
				a++;
			}else if (o0 == 'N' || o0 == 'n'){
				SubStu[a][b] = "N";
				a++;
			}
		}
		b++;
	}
while(1){
system("cls");

	cout <<"\t\t________________________________________" <<endl;
	cout <<"\t\t|                                      |" <<endl;
	cout <<"\t\t|               OPTION                 |" <<endl;
	cout <<"\t\t|       1.Check list of Students       |" <<endl;
	cout <<"\t\t|       2.Check list of Subjects       |" <<endl;
	cout <<"\t\t|                                      |" <<endl;	
	cout <<"\t\t|______________________________________|" <<endl;	
	cout<<endl;
	
	cout <<"What option do you want to use? (1 or 2) : ";
	cin >> o1;
	system("cls");
	
	if(o1 == 1){
		cout <<"\tThere are "<<StuNo <<" student(s) in your class."<<endl<<endl;
		k=0;
		l=1;	
		for(i=0;i<StuNo;i++){
			m=1;
			d=1;
			f=0;
			cout <<"\n\n\t" <<SubStu[k][l] <<" is enrolled in the following subjects"<<endl;
			for(j=0;j<AllSub;j++){
				if(SubStu[m][n] == "Y"){
				cout <<"\t\t\t" <<SubStu[d][f]<<endl;
				m++;
				d++;
				}else if (SubStu[m][n] == "N"){
					m++;
					d++;
					}
				}
			n++;
			l++;
			cout <<endl<<endl;
			cout <<"Go to next page, ";			
			system("pause");
			system("cls");
			}
		}else if(o1 == 2){
		cout <<"\tThere are "<<AllSub <<" subject(s) in your class."<<endl<<endl;
		k=1;
		l=0;	
		for(i=0;i<AllSub;i++){
			d=0;
			f=1;
			h=1;	
			cout <<"\n\n\t" <<SubStu[k][l] <<" is enrolled by the following stuedents"<<endl;
			for(j=0;j<AllSub;j++){
				if(SubStu[g][h] == "Y"){
				cout <<"\t\t\t" <<SubStu[d][f]<<endl;
				h++;
				f++;
				}else if (SubStu[g][h] == "N"){
					h++;
					f++;
					}
				}
			g++;
			k++;
			cout <<endl<<endl;
			cout <<"Go to next page, ";
			system("pause");
			system("cls");
			}
		
	}
	cout <<"Do you want to check again? (Y or N) : ";
	cin >>o2;
	if(o2 == 'Y' || o2 == 'y'){
		system("cls");
	}else if(o2 == 'N' || o2 == 'n'){
		system("cls");
		break;	
	}
}

	cout <<"\t\t****************************************" <<endl;
	cout <<"\t\t*******                          *******" <<endl;
	cout <<"\t\t    ******                    ******    " <<endl;
	cout <<"\t\t      *****GOOD LUCK,HAVE FUN*****      " <<endl;
	cout <<"\t\t    ******                    ******    " <<endl;
	cout <<"\t\t*******                          *******" <<endl;	
	cout <<"\t\t****************************************" <<endl;	
	return 0;

}
