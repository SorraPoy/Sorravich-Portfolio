#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;


int random(int x){
	int r = rand()%x;
	return r;
}

int main()
{
	cout <<endl;
	cout <<"*************************This is Pok-Deng card game*************************"<<endl;
	cout <<endl<<endl;
while(1){
	srand(time(NULL));
	
	string Cards[]{
		"Ace","two","three","four","five","six","seven","eight","nine","ten","king","queen","jack"
	};
	string Symbol[]{
		"clubs","diamonds","hearts","spades"
	};
	string Answer;
	string Yes = "Y";
	string No = "N";
	int firstnum = random(13);
	int secondnum = random(13);
	int thirdnum = random(13);
	int firstsym = random(4);
	int secondsym = random(4);
	int thirdsym = random(4);
	int botfnum = random(13);
	int botsnum = random(13);
	int bottnum = random(13);
	int botfsym = random(4);
	int botssym = random(4);
	int bottsym = random(4);
	int sum;
	int sumPer;

	cout <<"You have the "<<Cards[firstnum]<<" of "<<Symbol[firstsym]<<endl;
	cout <<"And the "<<Cards[secondnum]<<" of " <<Symbol[secondsym]<<endl;	
	
		cout <<"Do you want to draw a card? (Y or N) : ";
		cin >>Answer;
		cout <<endl <<endl;
		
		if (Answer == Yes){
			cout <<"You have the " <<Cards[firstnum] <<" of "<<Symbol[firstsym] <<endl;
			cout <<"And the "<<Cards[secondnum] <<" of "<<Symbol[secondsym] <<endl;
			cout <<"And the last one is "<<Cards[thirdnum] <<" of "<<Symbol[thirdsym]<<endl<<endl;
			
			cout <<"Enemy have the "<<Cards[botfnum] <<" of "<<Symbol[botfsym]<<endl;
			cout <<"And the "<<Cards[botsnum] <<" of "<<Symbol[botssym]<<endl;
			if (botfnum <= 9 && botsnum <= 9){
				sum = (botfnum + 1) + (botsnum + 1);
				if(sum<=5){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}else if (sum >=6 && sum <= 9){
					cout <<endl;
				}else if (sum >=10 && sum <= 15){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}else if (sum >= 16 && sum <= 19){
					cout <<endl;
				}else{
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}		
			}else if (botfnum == 10 && botsnum <=9){
				sum = botfnum + (botsnum + 1);
				if(sum<=15 || sum == 20){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}
			}else if (botfnum == 11 && botsnum <=9){
				sum = (botfnum - 1) + (botsnum + 1);
				if(sum<=15 || sum == 20){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}
			}else if (botfnum == 12 && botsnum <=9){
				sum = (botfnum - 2) + (botsnum + 1);
				if(sum<=15 || sum == 20){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}
			}else if (botfnum >= 9 && botsnum >= 9){
				cout <<"And the last card is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
			}else if (botfnum <=9 && botsnum == 12){
				sum = (botfnum + 1) + (botsnum - 2);
				if(sum<=15 || sum == 20){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}
			}else if (botfnum <=9 && botsnum == 11){
				sum = (botfnum + 1) + (botsnum - 1);
				if(sum<=15 || sum == 20){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}
			}else if (botfnum <=9 && botsnum == 10){
				sum = (botfnum + 1) + botsnum;
				if(sum<=15 || sum == 20){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}
			}
			if (sum <= 5 || sum >=10 && sum <= 15 || sum == 20){
			
				if (bottnum <= 9){
					sum = sum + (bottnum +1);
				}else if (bottnum == 10){
					sum = sum + bottnum;
				}else if (bottnum == 11){
					sum = sum + (bottnum - 1);
				}else if (bottnum == 12){
					sum = sum + (bottnum - 2);
				}
			}else if (sum >= 6 && sum <=9 || sum >= 16 && sum <= 19){
				if (sum>=10){
					sum = sum%10;
				}else{
				}
			}
			if (firstnum <= 9 && secondnum <= 9 && thirdnum <= 9){
				sumPer = ((firstnum + 1) + (secondnum + 1) + (thirdnum + 1));
				if (sumPer >= 10){
					sumPer = sumPer%10;
				}else{
				}
				cout <<"	You "<<sumPer <<" : Enemy " <<sum<<endl;
				if (sumPer > sum){
				cout <<"	WOWWWWW, YOU WIN!!!" <<endl;
				}else if (sumPer < sum){
					cout <<"	SAD, YOU LOSE HAHA" <<endl;
				}else if (sumPer == sum){
					cout <<"	LUCKY?, TIE"<<endl;
				}
			}else if (firstnum >=10 && secondnum <= 9 && thirdnum <= 9){
				sumPer = (10 + (secondnum + 1) + (thirdnum + 1));
				if (sumPer >= 10){
					sumPer = sumPer%10;
				}else{
				}
				cout <<"	You "<<sumPer <<" : Enemy " <<sum<<endl;
				if (sumPer > sum){
				cout <<"	WOWWWWW, YOU WIN!!!" <<endl;
				}else if (sumPer < sum){
					cout <<"	SAD, YOU LOSE HAHA" <<endl;
				}else if (sumPer == sum){
					cout <<"	LUCKY?, TIE"<<endl;
				}
			}else if (firstnum >=10 && secondnum >= 10 && thirdnum <= 9){
				sumPer = (10 + 10 + (thirdnum + 1));
				if (sumPer >= 10){
					sumPer = sumPer%10;
				}else{
				}
				cout <<"	You "<<sumPer <<" : Enemy " <<sum<<endl;
				if (sumPer > sum){
				cout <<"	WOWWWWW, YOU WIN!!!" <<endl;
				}else if (sumPer < sum){
					cout <<"	SAD, YOU LOSE HAHA" <<endl;
				}else if (sumPer == sum){
					cout <<"	LUCKY?, TIE"<<endl;
				}
			}else if (firstnum >=10 && secondnum >= 10 && thirdnum >= 10){
				sumPer = (10 + 10 + 10);
				if (sumPer >= 10){
					sumPer = sumPer%10;
				}else{
				}
				cout <<"	You "<<sumPer <<" : Enemy " <<sum<<endl;
				if (sumPer > sum){
				cout <<"	WOWWWWW, YOU WIN!!!" <<endl;
				}else if (sumPer < sum){
					cout <<"	SAD, YOU LOSE HAHA" <<endl;
				}else if (sumPer == sum){
					cout <<"	LUCKY?, TIE"<<endl;
				}
			}else if (firstnum <=9 && secondnum >= 10 && thirdnum <= 9){
				sumPer = ((firstnum + 1) + 10 + (thirdnum + 1));
				if (sumPer >= 10){
					sumPer = sumPer%10;
				}else{
				}
				cout <<"	You "<<sumPer <<" : Enemy " <<sum<<endl;
				if (sumPer > sum){
				cout <<"	WOWWWWW, YOU WIN!!!" <<endl;
				}else if (sumPer < sum){
					cout <<"	SAD, YOU LOSE HAHA" <<endl;
				}else if (sumPer == sum){
					cout <<"	LUCKY?, TIE"<<endl;
				}
			}else if (firstnum <=9 && secondnum >= 10 && thirdnum >= 10){
				sumPer = ((firstnum + 1) + 10 + 10);
				if (sumPer >= 10){
					sumPer = sumPer%10;
				}else{
				}
				cout <<"	You "<<sumPer <<" : Enemy " <<sum<<endl;
				if (sumPer > sum){
				cout <<"		WOWWWWW, YOU WIN!!!" <<endl;
				}else if (sumPer < sum){
					cout <<"	SAD, YOU LOSE HAHA" <<endl;
				}else if (sumPer == sum){
					cout <<"	LUCKY?, TIE"<<endl;
				}
			}else if (firstnum <=9 && secondnum <= 9 && thirdnum >= 10){
				sumPer = ((firstnum + 1) + (secondnum + 1) + 10);
				if (sumPer >= 10){
					sumPer = sumPer%10;
				}else{
				}
				cout <<"	You "<<sumPer <<" : Enemy " <<sum<<endl;
				if (sumPer > sum){
				cout <<"	WOWWWWW, YOU WIN!!!" <<endl;
				}else if (sumPer < sum){
					cout <<"	SAD, YOU LOSE HAHA" <<endl;
				}else if (sumPer == sum){
					cout <<"	LUCKY?, TIE"<<endl;
				}
			}else if (firstnum >=10 && secondnum <= 9 && thirdnum >= 10){
				sumPer = (10 + (secondnum + 1) + 10);
				if (sumPer >= 10){
					sumPer = sumPer%10;
				}else{
				}
				cout <<"	You "<<sumPer <<" : Enemy " <<sum<<endl;
				if (sumPer > sum){
				cout <<"	WOWWWWW, YOU WIN!!!" <<endl;
				}else if (sumPer < sum){
					cout <<"	SAD, YOU LOSE HAHA" <<endl;
				}else if (sumPer == sum){
					cout <<"	LUCKY?, TIE"<<endl;
				}
			}
			
		}else if (Answer == No){
			cout <<"You have the " <<Cards[firstnum] <<" of "<<Symbol[firstsym]<<endl;
			cout <<"And the "<<Cards[secondnum] <<" of "<<Symbol[secondsym] <<endl<<endl;
			
			cout <<"Enemy have the "<<Cards[botfnum] <<" of "<<Symbol[botfsym]<<endl;
			cout <<"And the "<<Cards[botsnum] <<" of "<<Symbol[botssym]<<endl;
			if (botfnum <= 9 && botsnum <= 9){
				sum = (botfnum + 1) + (botsnum + 1);
				if(sum<=5){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}else if (sum >=6 && sum <= 9){
					cout <<endl;
				}else if (sum >=10 && sum <= 15){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}else if (sum >= 16 && sum <= 19){
					cout <<endl;
				}else{
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}		
			}else if (botfnum == 10 && botsnum <=9){
				sum = botfnum + (botsnum + 1);
				if(sum<=15 || sum == 20){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}
			}else if (botfnum == 11 && botsnum <=9){
				sum = (botfnum - 1) + (botsnum + 1);
				if(sum<=15 || sum == 20){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}
			}else if (botfnum == 12 && botsnum <=9){
				sum = (botfnum - 2) + (botsnum + 1);
				if(sum<=15 || sum == 20){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}
			}else if (botfnum >= 9 && botsnum >= 9){
				cout <<"And the last card is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
			}else if (botfnum <=9 && botsnum == 12){
				sum = (botfnum + 1) + (botsnum - 2);
				if(sum<=15 || sum == 20){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}
			}else if (botfnum <=9 && botsnum == 11){
				sum = (botfnum + 1) + (botsnum - 1);
				if(sum<=15 || sum == 20){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}
			}else if (botfnum <=9 && botsnum == 10){
				sum = (botfnum + 1) + botsnum;
				if(sum<=15 || sum == 20){
					cout <<"And the last one is "<<Cards[bottnum] <<" of "<<Symbol[bottsym] <<endl;
				}
			}
			if (sum <= 5 || sum >=10 && sum <= 15 || sum == 20){
			
				if (bottnum <= 9){
					sum = sum + (bottnum +1);
				}else if (bottnum == 10){
					sum = sum + bottnum;
				}else if (bottnum == 11){
					sum = sum + (bottnum - 1);
				}else if (bottnum == 12){
					sum = sum + (bottnum - 2);
				}
			}else if (sum >= 5 && sum <=9 || sum >= 15 && sum <= 19){
			}
				if (sum>=10){
					sum = sum%10;
				}else{
				}
				if (firstnum <= 9 && secondnum <= 9){
					sumPer = ((firstnum + 1) + (secondnum + 1));
				if (sumPer >= 10){
					sumPer = sumPer%10;
				}else{
				}
				cout <<"	You "<<sumPer <<" : Enemy " <<sum<<endl;
				if (sumPer > sum){
				cout <<"	WOWWWWW, YOU WIN!!!" <<endl;
				}else if (sumPer < sum){
					cout <<"	SAD, YOU LOSE HAHA" <<endl;
				}else if (sumPer == sum){
					cout <<"	LUCKY?, TIE"<<endl;
				}
			}else if (firstnum >= 10 && secondnum <= 9){
					sumPer = (10 + (secondnum + 1));
				if (sumPer >= 10){
					sumPer = sumPer%10;
				}else{
				}
				cout <<"	You "<<sumPer <<" : Enemy " <<sum<<endl;
				if (sumPer > sum){
				cout <<"	WOWWWWW, YOU WIN!!!" <<endl;
				}else if (sumPer < sum){
					cout <<"	SAD, YOU LOSE HAHA" <<endl;
				}else if (sumPer == sum){
					cout <<"	LUCKY?, TIE"<<endl;
				}
			}else if (firstnum >= 10 && secondnum >= 10){
					sumPer = (10 + 10);
				if (sumPer >= 10){
					sumPer = sumPer%10;
				}else{
				}
				cout <<"	You "<<sumPer <<" : Enemy " <<sum<<endl;
				if (sumPer > sum){
				cout <<"	WOWWWWW, YOU WIN!!!" <<endl;
				}else if (sumPer < sum){
					cout <<"	SAD, YOU LOSE HAHA" <<endl;
				}else if (sumPer == sum){
					cout <<"	LUCKY?, TIE"<<endl;
				}
			}else if (firstnum <= 9 && secondnum >= 10){
					sumPer = ((firstnum + 1) + 10);
				if (sumPer >= 10){
					sumPer = sumPer%10;
				}else{
				}
				cout <<"	You "<<sumPer <<" : Enemy " <<sum<<endl;
				if (sumPer > sum){
				cout <<"	WOWWWWW, YOU WIN!!!" <<endl;
				}else if (sumPer < sum){
					cout <<"	SAD, YOU LOSE HAHA" <<endl;
				}else if (sumPer == sum){
					cout <<"	LUCKY?, TIE"<<endl;
				}
			}
					
	}else{
		cout <<"***********Don't know what to do***********"<<endl;
	}


	cout <<endl <<"Do you want to go on (Y or N)? : ";
	cin >>Answer;
	if(Answer == Yes){
		cout <<endl <<"**************NEXT ROUND**************"<<endl<<endl;
	}else if(Answer == No){
		cout <<endl <<endl<<"*********************GOOD LUCK, HAVE FUN*********************"<<endl;
		break;
	}else {
		cout <<endl<<endl <<"***********I CAN'T DO THAT***********" <<endl;
		break;
	}

}
	system("pause");
	return 0;
}


