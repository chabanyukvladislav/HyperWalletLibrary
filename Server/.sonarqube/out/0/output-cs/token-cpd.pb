ﬂ
NC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Api\IApiWorker.cs
	namespace 	
Server
 
. 
Api 
{ 
public 

	interface 

IApiWorker 
<  
T  !
>! "
where# (
T) *
:+ ,
IModel- 3
{ 
Task		 
<		 
List		 
<		 
T		 
>		 
>		 
GetAsync		 
(		 
)		  
;		  !
Task

 
<

 
T

 
>

 
GetAsync

 
(

 
string

 
token

  %
)

% &
;

& '
Task 
< 
T 
> 
	PostAsync 
( 
T 
item  
)  !
;! "
Task 
< 
T 
> 
PutAsync 
( 
string 
token  %
,% &
T' (
value) .
). /
;/ 0
} 
} Ÿ)
TC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Api\PaymentApiWorker.cs
	namespace 	
Server
 
. 
Api 
{		 
public

 

class

 
PaymentApiWorker

 !
:

" #

IApiWorker

$ .
<

. /
Payment

/ 6
>

6 7
{ 
private 
readonly 
HyperWalletLibrary +
.+ ,
Api, /
./ 0
Payment0 7
_api8 <
;< =
private 
readonly (
PaymentToApiPaymentConverter 5 
_paymentToApiPayment6 J
;J K
private 
readonly 4
(ResponseApiPaymentToListPaymentConverter A,
 _responseApiPaymentToListPaymentB b
;b c
public 
PaymentApiWorker 
(  
)  !
{ 	
_api 
= 
new 
HyperWalletLibrary )
.) *
Api* -
.- .
Payment. 5
(5 6
Account6 =
.= >
HyperWalletAccount> P
)P Q
;Q R 
_paymentToApiPayment  
=! "
new# &(
PaymentToApiPaymentConverter' C
(C D
)D E
;E F,
 _responseApiPaymentToListPayment ,
=- .
new/ 24
(ResponseApiPaymentToListPaymentConverter3 [
([ \
)\ ]
;] ^
} 	
public 
async 
Task 
< 
List 
< 
Payment &
>& '
>' (
GetAsync) 1
(1 2
)2 3
{ 	
try 
{ 
HyperWalletLibrary "
." #
Model# (
.( )
Response) 1
<1 2
HyperWalletLibrary2 D
.D E
ModelE J
.J K
PaymentK R
>R S
responseT \
=] ^
await_ d
_apie i
.i j
GetAsyncj r
(r s
)s t
;t u,
 _responseApiPaymentToListPayment 0
.0 1
Content1 8
=9 :
response; C
;C D
List 
< 
Payment 
> 
list "
=# $,
 _responseApiPaymentToListPayment% E
.E F
ConvertF M
(M N
)N O
;O P
return 
list 
; 
} 
catch   
(   
	Exception   
)   
{!! 
return"" 
null"" 
;"" 
}## 
}$$ 	
public&& 
async&& 
Task&& 
<&& 
Payment&& !
>&&! "
GetAsync&&# +
(&&+ ,
string&&, 2
token&&3 8
)&&8 9
{'' 	
try(( 
{)) 
HyperWalletLibrary** "
.**" #
Model**# (
.**( )
Payment**) 0
response**1 9
=**: ;
await**< A
_api**B F
.**F G
GetAsync**G O
(**O P
token**P U
)**U V
;**V W
Payment++ 
payment++ 
=++  !
new++" %
Payment++& -
(++- .
response++. 6
)++6 7
;++7 8
return,, 
payment,, 
;,, 
}-- 
catch.. 
(.. 
	Exception.. 
).. 
{// 
return00 
null00 
;00 
}11 
}22 	
public44 
async44 
Task44 
<44 
Payment44 !
>44! "
	PostAsync44# ,
(44, -
Payment44- 4
item445 9
)449 :
{55 	
try66 
{77  
_paymentToApiPayment88 $
.88$ %
Content88% ,
=88- .
item88/ 3
;883 4
HyperWalletLibrary99 "
.99" #
Model99# (
.99( )
Payment99) 0
newItem991 8
=999 : 
_paymentToApiPayment99; O
.99O P
Convert99P W
(99W X
)99X Y
;99Y Z
HyperWalletLibrary:: "
.::" #
Model::# (
.::( )
Payment::) 0
response::1 9
=::: ;
await::< A
_api::B F
.::F G
	PostAsync::G P
(::P Q
newItem::Q X
)::X Y
;::Y Z
Payment;; 
payment;; 
=;;  !
new;;" %
Payment;;& -
(;;- .
response;;. 6
);;6 7
;;;7 8
return<< 
payment<< 
;<< 
}== 
catch>> 
(>> 
	Exception>> 
)>> 
{?? 
return@@ 
null@@ 
;@@ 
}AA 
}BB 	
publicDD 
TaskDD 
<DD 
PaymentDD 
>DD 
PutAsyncDD %
(DD% &
stringDD& ,
tokenDD- 2
,DD2 3
PaymentDD4 ;
valueDD< A
)DDA B
{EE 	
returnFF 
nullFF 
;FF 
}GG 	
}HH 
}II ’0
QC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Api\UserApiWorker.cs
	namespace 	
Server
 
. 
Api 
{ 
public		 

class		 
UserApiWorker		 
:		  

IApiWorker		! +
<		+ ,
User		, 0
>		0 1
{

 
private 
readonly 
HyperWalletLibrary +
.+ ,
Api, /
./ 0
User0 4
_api5 9
;9 :
private 
readonly "
UserToApiUserConverter /
_userToApiUser0 >
;> ?
private 
readonly .
"ResponseApiUserToListUserConverter ;&
_responseApiUserToListUser< V
;V W
public 
UserApiWorker 
( 
) 
{ 	
_api 
= 
new 
HyperWalletLibrary )
.) *
Api* -
.- .
User. 2
(2 3
Account3 :
.: ;
HyperWalletAccount; M
)M N
;N O
_userToApiUser 
= 
new  "
UserToApiUserConverter! 7
(7 8
)8 9
;9 :&
_responseApiUserToListUser &
=' (
new) ,.
"ResponseApiUserToListUserConverter- O
(O P
)P Q
;Q R
} 	
public 
async 
Task 
< 
List 
< 
User #
># $
>$ %
GetAsync& .
(. /
)/ 0
{ 	
try 
{ 
HyperWalletLibrary "
." #
Model# (
.( )
Response) 1
<1 2
HyperWalletLibrary2 D
.D E
ModelE J
.J K
UserK O
>O P
responseQ Y
=Z [
await\ a
_apib f
.f g
GetAsyncg o
(o p
)p q
;q r&
_responseApiUserToListUser *
.* +
Content+ 2
=3 4
response5 =
;= >
List 
< 
User 
> 
list 
=  !&
_responseApiUserToListUser" <
.< =
Convert= D
(D E
)E F
;F G
return 
list 
; 
} 
catch 
( 
	Exception 
) 
{   
return!! 
null!! 
;!! 
}"" 
}## 	
public%% 
async%% 
Task%% 
<%% 
User%% 
>%% 
GetAsync%%  (
(%%( )
string%%) /
token%%0 5
)%%5 6
{&& 	
try'' 
{(( 
HyperWalletLibrary)) "
.))" #
Model))# (
.))( )
User))) -
response)). 6
=))7 8
await))9 >
_api))? C
.))C D
GetAsync))D L
())L M
token))M R
)))R S
;))S T
User** 
user** 
=** 
new** 
User**  $
(**$ %
response**% -
)**- .
;**. /
return++ 
user++ 
;++ 
},, 
catch-- 
(-- 
	Exception-- 
)-- 
{.. 
return// 
null// 
;// 
}00 
}11 	
public33 
async33 
Task33 
<33 
User33 
>33 
	PostAsync33  )
(33) *
User33* .
item33/ 3
)333 4
{44 	
try55 
{66 
_userToApiUser77 
.77 
Content77 &
=77' (
item77) -
;77- .
HyperWalletLibrary88 "
.88" #
Model88# (
.88( )
User88) -
newItem88. 5
=886 7
_userToApiUser888 F
.88F G
Convert88G N
(88N O
)88O P
;88P Q
HyperWalletLibrary99 "
.99" #
Model99# (
.99( )
User99) -
response99. 6
=997 8
await999 >
_api99? C
.99C D
	PostAsync99D M
(99M N
newItem99N U
)99U V
;99V W
User:: 
user:: 
=:: 
new:: 
User::  $
(::$ %
response::% -
)::- .
;::. /
return;; 
user;; 
;;; 
}<< 
catch== 
(== 
	Exception== 
)== 
{>> 
return?? 
null?? 
;?? 
}@@ 
}AA 	
publicCC 
asyncCC 
TaskCC 
<CC 
UserCC 
>CC 
PutAsyncCC  (
(CC( )
stringCC) /
tokenCC0 5
,CC5 6
UserCC7 ;
itemCC< @
)CC@ A
{DD 	
tryEE 
{FF 
_userToApiUserGG 
.GG 
ContentGG &
=GG' (
itemGG) -
;GG- .
HyperWalletLibraryHH "
.HH" #
ModelHH# (
.HH( )
UserHH) -
newItemHH. 5
=HH6 7
_userToApiUserHH8 F
.HHF G
ConvertHHG N
(HHN O
)HHO P
;HHP Q
HyperWalletLibraryII "
.II" #
ModelII# (
.II( )
UserII) -
responseII. 6
=II7 8
awaitII9 >
_apiII? C
.IIC D
PutAsyncIID L
(IIL M
tokenIIM R
,IIR S
newItemIIT [
)II[ \
;II\ ]
UserJJ 
userJJ 
=JJ 
newJJ 
UserJJ  $
(JJ$ %
responseJJ% -
)JJ- .
;JJ. /
returnKK 
userKK 
;KK 
}LL 
catchMM 
(MM 
	ExceptionMM 
)MM 
{NN 
returnOO 
nullOO 
;OO 
}PP 
}QQ 	
}RR 
}SS ¶
QC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Component\Account.cs
	namespace 	
Server
 
. 
	Component 
{ 
public 

static 
class 
Account 
{ 
public 
static 
IHyperWalletAccount )
HyperWalletAccount* <
{ 	
get		 
{

 
IHyperWalletAccount #
account$ +
=, -
new. 1
HyperWalletAccount2 D
{ 
Main 
= 
new 
HyperWalletProgram 1
(1 2
)2 3
{ 
Password  
=! "
$str# /
,/ 0
ProgramToken $
=% &
$str' Q
,Q R
Username  
=! "
$str# <
} 
, 
Portal 
= 
new  
HyperWalletProgram! 3
(3 4
)4 5
{ 
Password  
=! "
$str# /
,/ 0
ProgramToken $
=% &
$str' Q
,Q R
Username  
=! "
$str# <
} 
, 
Card 
= 
new 
HyperWalletProgram 1
(1 2
)2 3
{ 
Password  
=! "
$str# /
,/ 0
ProgramToken $
=% &
$str' Q
,Q R
Username  
=! "
$str# <
} 
, 
Direct 
= 
new  
HyperWalletProgram! 3
(3 4
)4 5
{   
Password!!  
=!!! "
$str!!# /
,!!/ 0
ProgramToken"" $
=""% &
$str""' Q
,""Q R
Username##  
=##! "
$str### <
}$$ 
,$$ 
Select%% 
=%% 
new%%  
HyperWalletProgram%%! 3
(%%3 4
)%%4 5
{&& 
Password''  
=''! "
$str''# /
,''/ 0
ProgramToken(( $
=((% &
$str((' Q
,((Q R
Username))  
=))! "
$str))# <
}** 
}++ 
;++ 
return,, 
account,, 
;,, 
}-- 
}.. 	
}// 
}00 æ
TC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Component\IConverter.cs
	namespace 	
Server
 
. 
	Component 
{ 
public 

	interface 

IConverter 
<  
T  !
,! "
Q# $
>$ %
{ 
Q 	
Content
 
{ 
get 
; 
set 
; 
} 
T 	
Convert
 
( 
) 
; 
} 
}		 ø
[C:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Component\IPaymentConverter.cs
	namespace 	
Server
 
. 
	Component 
{ 
	interface 
IPaymentConverter 
<  
T  !
>! "
:# $

IConverter% /
</ 0
T0 1
,1 2
Payment3 :
>: ;
{ 
} 
} â
fC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Component\IResponseApiPaymentConverter.cs
	namespace 	
Server
 
. 
	Component 
{ 
	interface (
IResponseApiPaymentConverter *
<* +
T+ ,
>, -
:. /

IConverter0 :
<: ;
T; <
,< =
Response> F
<F G
PaymentG N
>N O
>O P
{ 
} 
} î
cC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Component\IResponseApiUserConverter.cs
	namespace 	
Server
 
. 
	Component 
{ 
public 

	interface %
IResponseApiUserConverter .
<. /
T/ 0
>0 1
:2 3

IConverter4 >
<> ?
T? @
,@ A
ResponseB J
<J K
UserK O
>O P
>P Q
{ 
} 
}		 Œ
YC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Component\ITokenConverter.cs
	namespace 	
Server
 
. 
	Component 
{ 
public 

	interface 
ITokenConverter $
<$ %
T% &
>& '
:( )

IConverter* 4
<4 5
T5 6
,6 7
string8 >
>> ?
{ 
} 
}  
XC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Component\IUserConverter.cs
	namespace 	
Server
 
. 
	Component 
{ 
public 

	interface 
IUserConverter #
<# $
T$ %
>% &
:' (

IConverter) 3
<3 4
T4 5
,5 6
User7 ;
>; <
{ 
} 
}		 ≠
oC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Component\Payments\PaymentToApiPaymentConverter.cs
	namespace 	
Server
 
. 
	Component 
. 
Payments #
{ 
public 

class (
PaymentToApiPaymentConverter -
:. /
IPaymentConverter0 A
<A B
HyperWalletLibraryB T
.T U
ModelU Z
.Z [
Payment[ b
>b c
{ 
public 
Payment 
Content 
{  
get! $
;$ %
set& )
;) *
}+ ,
public		 (
PaymentToApiPaymentConverter		 +
(		+ ,
Payment		, 3
content		4 ;
=		< =
null		> B
)		B C
{

 	
Content 
= 
content 
; 
} 	
public 
HyperWalletLibrary !
.! "
Model" '
.' (
Payment( /
Convert0 7
(7 8
)8 9
{ 	
if 
( 
Content 
== 
null 
)  
return! '
null( ,
;, -
HyperWalletLibrary 
. 
Model $
.$ %
Payment% ,
payment- 4
=5 6
new7 :
HyperWalletLibrary; M
.M N
ModelN S
.S T
PaymentT [
{ 
Token 
= 
Content 
.  
Token  %
,% &
Amount 
= 
Content  
.  !
Amount! '
,' (
DestinationToken  
=! "
Content# *
.* +
DestinationToken+ ;
,; <
	ExpiresOn 
= 
Content #
.# $
	ExpiresOn$ -
,- .
Notes 
= 
Content 
.  
Notes  %
} 
; 
return 
payment 
; 
} 	
} 
} ù
{C:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Component\Payments\ResponseApiPaymentToListPaymentConverter.cs
	namespace 	
Server
 
. 
	Component 
. 
Payments #
{ 
public 

class 4
(ResponseApiPaymentToListPaymentConverter 9
:: ;(
IResponseApiPaymentConverter< X
<X Y
ListY ]
<] ^
Database^ f
.f g
Modelg l
.l m
Paymentm t
>t u
>u v
{ 
public		 
Response		 
<		 
Payment		 
>		  
Content		! (
{		) *
get		+ .
;		. /
set		0 3
;		3 4
}		5 6
public 4
(ResponseApiPaymentToListPaymentConverter 7
(7 8
Response8 @
<@ A
PaymentA H
>H I
contentJ Q
=R S
nullT X
)X Y
{ 	
Content 
= 
content 
; 
} 	
public 
List 
< 
Database 
. 
Model "
." #
Payment# *
>* +
Convert, 3
(3 4
)4 5
{ 	
if 
( 
Content 
== 
null 
)  
return! '
null( ,
;, -
List 
< 
Database 
. 
Model 
.  
Payment  '
>' (
list) -
=. /
new0 3
List4 8
<8 9
Database9 A
.A B
ModelB G
.G H
PaymentH O
>O P
(P Q
)Q R
;R S
foreach 
( 
Payment 
payment $
in% '
Content( /
./ 0
Data0 4
)4 5
{ 
Database 
. 
Model 
. 
Payment &
value' ,
=- .
new/ 2
Database3 ;
.; <
Model< A
.A B
PaymentB I
(I J
paymentJ Q
)Q R
;R S
list 
. 
Add 
( 
value 
) 
;  
} 
return 
list 
; 
} 	
} 
} Æ
rC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Component\Users\ResponseApiUserToListUserConverter.cs
	namespace 	
Server
 
. 
	Component 
{ 
public 

class .
"ResponseApiUserToListUserConverter 3
:4 5%
IResponseApiUserConverter6 O
<O P
ListP T
<T U
UserU Y
>Y Z
>Z [
{ 
public 
HyperWalletLibrary !
.! "
Model" '
.' (
Response( 0
<0 1
HyperWalletLibrary1 C
.C D
ModelD I
.I J
UserJ N
>N O
ContentP W
{X Y
getZ ]
;] ^
set_ b
;b c
}d e
public

 
List

 
<

 
User

 
>

 
Convert

 !
(

! "
)

" #
{ 	
if 
( 
Content 
== 
null 
)  
return! '
null( ,
;, -
List 
< 
User 
> 
list 
= 
new !
List" &
<& '
User' +
>+ ,
(, -
)- .
;. /
foreach 
( 
HyperWalletLibrary '
.' (
Model( -
.- .
User. 2
apiUser3 :
in; =
Content> E
.E F
DataF J
)J K
{ 
User 
user 
= 
new 
User  $
($ %
apiUser% ,
), -
;- .
list 
. 
Add 
( 
user 
) 
; 
} 
return 
list 
; 
} 	
public .
"ResponseApiUserToListUserConverter 1
(1 2
HyperWalletLibrary 
. 
Model $
.$ %
Response% -
<- .
HyperWalletLibrary. @
.@ A
ModelA F
.F G
UserG K
>K L
contentM T
=U V
nullW [
)[ \
{ 	
Content 
= 
content 
; 
} 	
} 
} µ
dC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Component\Users\TokenToUserConverter.cs
	namespace 	
Server
 
. 
	Component 
{ 
public 

class  
TokenToUserConverter %
:& '
ITokenConverter( 7
<7 8
User8 <
>< =
{ 
private		 
const		 
string		 
ID_CLAIM_TYPE		 *
=		+ ,
$str		- 2
;		2 3
private

 
const

 
string

 
NAME_CLAIM_TYPE

 ,
=

- .
$str

/ ;
;

; <
private 
const 
string 
SURNAME_CLAIM_TYPE /
=0 1
$str2 ?
;? @
private 
const 
string 
NICKNAME_CLAIM_TYPE 0
=1 2
$str3 =
;= >
public 
string 
Content 
{ 
get  #
;# $
set% (
;( )
}* +
public  
TokenToUserConverter #
(# $
string$ *
content+ 2
=3 4
null5 9
)9 :
{ 	
Content 
= 
content 
; 
} 	
public 
User 
Convert 
( 
) 
{ 	
if 
( 
Content 
== 
null 
)  
return! '
null( ,
;, -#
JwtSecurityTokenHandler #
handler$ +
=, -
new. 1#
JwtSecurityTokenHandler2 I
(I J
)J K
;K L
JwtSecurityToken 
security %
=& '
handler( /
./ 0
ReadJwtToken0 <
(< =
Content= D
)D E
;E F
User 
user 
= 
new 
User  
{ 
Id 
= 
security 
. 
Claims $
.$ %
FirstOrDefault% 3
(3 4
el4 6
=>7 9
el: <
.< =
Type= A
==B D
ID_CLAIM_TYPEE R
)R S
?S T
.T U
ValueU Z
,Z [
Email 
= 
security  
.  !
Claims! '
.' (
FirstOrDefault( 6
(6 7
el7 9
=>: <
el= ?
.? @
Type@ D
==E G
NICKNAME_CLAIM_TYPEH [
)[ \
?\ ]
.] ^
Value^ c
+d e
$strf r
,r s
	FirstName 
= 
security $
.$ %
Claims% +
.+ ,
FirstOrDefault, :
(: ;
el; =
=>> @
elA C
.C D
TypeD H
==I K
NAME_CLAIM_TYPEL [
)[ \
?\ ]
.] ^
Value^ c
,c d
LastName 
= 
security #
.# $
Claims$ *
.* +
FirstOrDefault+ 9
(9 :
el: <
=>= ?
el@ B
.B C
TypeC G
==H J
SURNAME_CLAIM_TYPEK ]
)] ^
?^ _
._ `
Value` e
}   
;   
return!! 
user!! 
;!! 
}"" 	
}## 
}$$ ◊
fC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Component\Users\TokenToUserIdConverter.cs
	namespace 	
Server
 
. 
	Component 
{ 
public 

class "
TokenToUserIdConverter '
:( )
ITokenConverter* 9
<9 :
string: @
>@ A
{ 
private 
const 
string 
ID_CLAIM_TYPE *
=+ ,
$str- 2
;2 3
public

 
string

 
Content

 
{

 
get

  #
;

# $
set

% (
;

( )
}

* +
public "
TokenToUserIdConverter %
(% &
string& ,
content- 4
=5 6
null7 ;
); <
{ 	
Content 
= 
content 
; 
} 	
public 
string 
Convert 
( 
) 
{ 	
if 
( 
Content 
== 
null 
)  
return! '
null( ,
;, -#
JwtSecurityTokenHandler #
handler$ +
=, -
new. 1#
JwtSecurityTokenHandler2 I
(I J
)J K
;K L
JwtSecurityToken 
security %
=& '
handler( /
./ 0
ReadJwtToken0 <
(< =
Content= D
)D E
;E F
string 
id 
= 
security  
.  !
Claims! '
.' (
FirstOrDefault( 6
(6 7
el7 9
=>: <
el= ?
.? @
Type@ D
==E G
ID_CLAIM_TYPEH U
)U V
.V W
ValueW \
;\ ]
return 
id 
; 
} 	
} 
} ¨
fC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Component\Users\UserToApiUserConverter.cs
	namespace 	
Server
 
. 
	Component 
{ 
public 

class "
UserToApiUserConverter '
:( )
IUserConverter* 8
<8 9
User9 =
>= >
{ 
public 
Database 
. 
Model 
. 
User "
Content# *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public		 
User		 
Convert		 
(		 
)		 
{

 	
if 
( 
Content 
== 
null 
)  
return! '
null( ,
;, -
User 
apiUser 
= 
new 
User #
{ 
Token 
= 
Content 
.  
Token  %
,% &
ClientUserId 
= 
Content &
.& '
Id' )
,) *
AddressLine1 
= 
Content &
.& '
AddressLine1' 3
,3 4
City 
= 
Content 
. 
City #
,# $
Country 
= 
Content !
.! "
Country" )
,) *
Email 
= 
Content 
.  
Email  %
,% &
	FirstName 
= 
Content #
.# $
	FirstName$ -
,- .
LastName 
= 
Content "
." #
LastName# +
,+ ,

MiddleName 
= 
Content $
.$ %

MiddleName% /
,/ 0
PhoneNumber 
= 
Content %
.% &
PhoneNumber& 1
,1 2

PostalCode 
= 
Content $
.$ %

PostalCode% /
,/ 0
StateProvince 
= 
Content  '
.' (
StateProvince( 5
} 
; 
return 
apiUser 
; 
} 	
public "
UserToApiUserConverter %
(% &
Database& .
.. /
Model/ 4
.4 5
User5 9
user: >
=? @
nullA E
)E F
{ 	
Content   
=   
user   
;   
}!! 	
}"" 
}## ¯
[C:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Controllers\LoginController.cs
	namespace

 	
Server


 
.

 
Controllers

 
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class 
LoginController  
:! "
ControllerBase# 1
{ 
private 
readonly 
IDatabaseWorker (
<( )
User) -
>- .
_databaseWorker/ >
;> ?
private 
readonly 
ITokenConverter (
<( )
string) /
>/ 0
_tokenConverter1 @
;@ A
private 
readonly 
IAccountService (
_accountService) 8
;8 9
private 
readonly 
ITokenService &
_tokenService' 4
;4 5
public 
LoginController 
( 
Context &
context' .
). /
{ 	
_databaseWorker 
= 
new !
UserDatabaseWorker" 4
(4 5
context5 <
)< =
;= >
_tokenConverter 
= 
new !"
TokenToUserIdConverter" 8
(8 9
)9 :
;: ;
_accountService 
= 
new !
AccountService" 0
(0 1
context1 8
)8 9
;9 :
_tokenService 
= 
new 
TokenService  ,
(, -
)- .
;. /
} 	
[ 	
HttpPost	 
] 
public 
async 
Task 
< 
Token 
>  
Post! %
(% &
[& '
FromBody' /
]/ 0
string1 7
token8 =
)= >
{ 	
_tokenConverter   
.   
Content   #
=  $ %
token  & +
;  + ,
string!! 
clientId!! 
=!! 
_tokenConverter!! -
.!!- .
Convert!!. 5
(!!5 6
)!!6 7
;!!7 8
User"" 
user"" 
="" 
await"" 
_databaseWorker"" -
.""- .
GetAsync"". 6
(""6 7
clientId""7 ?
)""? @
;""@ A
if## 
(## 
user## 
==## 
null## 
)## 
{$$ 
bool%% 
result%% 
=%% 
await%% #
_accountService%%$ 3
.%%3 4
RegistrateAsync%%4 C
(%%C D
token%%D I
)%%I J
;%%J K
if&& 
(&& 
!&& 
result&& 
)&& 
return'' 
null'' 
;''  
}(( 
Token)) 
	userToken)) 
=)) 
await)) #
_tokenService))$ 1
.))1 2
GetTokenAsync))2 ?
())? @
)))@ A
;))A B
return** 
	userToken** 
;** 
}++ 	
},, 
}-- ∏
^C:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Controllers\PaymentsController.cs
	namespace 	
Server
 
. 
Controllers 
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
[ 
	Authorize 
] 
public 

class 
PaymentsController #
:$ %
ControllerBase& 4
{ 
private 
readonly 
IApiService $
<$ %
Payment% ,
>, -
_service. 6
;6 7
private 
readonly 
IHubContext $
<$ %
NotificationHub% 4
>4 5
_hub6 :
;: ;
public 
PaymentsController !
(! "
Context" )
context* 1
,1 2
IHubContext3 >
<> ?
NotificationHub? N
>N O
hubP S
)S T
{ 	
_service 
= 
new 
PaymentService )
() *
context* 1
)1 2
;2 3
_hub 
= 
hub 
; 
} 	
[ 	
HttpGet	 
] 
public 
async 
Task 
< 
List 
< 
Payment &
>& '
>' (
Get) ,
(, -
)- .
{ 	
return 
await 
_service !
.! "
Get" %
(% &
)& '
;' (
} 	
[!! 	
HttpGet!!	 
(!! 
$str!! 
)!! 
]!! 
public"" 
async"" 
Task"" 
<"" 
Payment"" !
>""! "
Get""# &
(""& '
string""' -
id"". 0
)""0 1
{## 	
return$$ 
await$$ 
_service$$ !
.$$! "
Get$$" %
($$% &
id$$& (
)$$( )
;$$) *
}%% 	
['' 	
HttpPost''	 
]'' 
public(( 
async(( 
Task(( 
<(( 
bool(( 
>(( 
Post((  $
((($ %
[((% &
FromBody((& .
]((. /
Payment((0 7
value((8 =
)((= >
{)) 	
bool** 
result** 
=** 
await** 
_service**  (
.**( )
Post**) -
(**- .
value**. 3
)**3 4
;**4 5
if++ 
(++ 
result++ 
)++ 
await,, 
_hub,, 
.,, 
Clients,, "
.,," #
All,,# &
.,,& '
	SendAsync,,' 0
(,,0 1
$str,,1 >
,,,> ?
value,,@ E
),,E F
;,,F G
return-- 
result-- 
;-- 
}.. 	
}// 
}00 ã
[C:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Controllers\UsersController.cs
	namespace		 	
Server		
 
.		 
Controllers		 
{

 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
[ 
	Authorize 
] 
public 

class 
UsersController  
:! "
ControllerBase# 1
{ 
private 
readonly 
IUserService %
_service& .
;. /
public 
UsersController 
( 
Context &
context' .
). /
{ 	
_service 
= 
new 
UserService &
(& '
context' .
). /
;/ 0
} 	
[ 	
HttpGet	 
] 
public 
async 
Task 
< 
List 
< 
User #
># $
>$ %
Get& )
() *
)* +
{ 	
return 
await 
_service !
.! "
Get" %
(% &
)& '
;' (
} 	
[ 	
HttpGet	 
( 
$str 
) 
] 
public 
async 
Task 
< 
User 
> 
Get  #
(# $
string$ *
clientId+ 3
)3 4
{ 	
return   
await   
_service   !
.  ! "
Get  " %
(  % &
clientId  & .
)  . /
;  / 0
}!! 	
[## 	
HttpPost##	 
]## 
public$$ 
async$$ 
Task$$ 
<$$ 
bool$$ 
>$$ 
Post$$  $
($$$ %
[$$% &
FromBody$$& .
]$$. /
User$$0 4
value$$5 :
)$$: ;
{%% 	
return&& 
await&& 
_service&& !
.&&! "
Post&&" &
(&&& '
value&&' ,
)&&, -
;&&- .
}'' 	
[)) 	
HttpPut))	 
()) 
$str)) 
))) 
])) 
public** 
async** 
Task** 
<** 
bool** 
>** 
Put**  #
(**# $
string**$ *
clientId**+ 3
,**3 4
[**5 6
FromBody**6 >
]**> ?
User**@ D
value**E J
)**J K
{++ 	
return,, 
await,, 
_service,, !
.,,! "
Put,," %
(,,% &
clientId,,& .
,,,. /
value,,0 5
),,5 6
;,,6 7
}-- 	
}.. 
}// ò	
`C:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Database\DatabaseContext\Context.cs
	namespace 	
Server
 
. 
Database 
. 
DatabaseContext )
{ 
public 

class 
Context 
: 
	DbContext $
{ 
public 
DbSet 
< 
User 
> 
Users  
{! "
get# &
;& '
set( +
;+ ,
}- .
public		 
DbSet		 
<		 
Payment		 
>		 
Payments		 &
{		' (
get		) ,
;		, -
set		. 1
;		1 2
}		3 4
public 
Context 
( 
DbContextOptions '
<' (
Context( /
>/ 0
options1 8
)8 9
:: ;
base< @
(@ A
optionsA H
)H I
{ 	
Database 
. 
EnsureCreated "
(" #
)# $
;$ %
} 	
} 
} á	
XC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Database\IDatabaseWorker.cs
	namespace 	
Server
 
. 
Database 
{ 
public 

	interface 
IDatabaseWorker $
<$ %
T% &
>& '
where( -
T. /
:0 1
IModel2 8
{ 
Task		 
<		 
List		 
<		 
T		 
>		 
>		 
GetAsync		 
(		 
)		  
;		  !
Task

 
<

 
T

 
>

 
GetAsync

 
(

 
string

 
clientUserId

  ,
)

, -
;

- .
Task 
< 
bool 
> 
	PostAsync 
( 
T 
item #
)# $
;$ %
Task 
< 
bool 
> 
PutAsync 
( 
string "
clientUserId# /
,/ 0
T1 2
value3 8
)8 9
;9 :
} 
} ¿
UC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Database\Model\IModel.cs
	namespace 	
Server
 
. 
Database 
. 
Model 
{ 
public 

	interface 
IModel 
{ 
string 
Id 
{ 
get 
; 
set 
; 
} 
} 
} ﬁ
VC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Database\Model\Payment.cs
	namespace 	
Server
 
. 
Database 
. 
Model 
{ 
public 

class 
Payment 
: 
IModel !
{ 
public 
string 
Token 
{ 
get !
;! "
set# &
;& '
}( )
public 
double 
Amount 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 
Id 
{ 
get 
; 
set  #
;# $
}% &
public 
string 
DestinationToken &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public		 
string		 
	ExpiresOn		 
{		  !
get		" %
;		% &
set		' *
;		* +
}		, -
public

 
string

 
Notes

 
{

 
get

 !
;

! "
set

# &
;

& '
}

( )
public 
Payment 
( 
) 
{ 
} 
public 
Payment 
( 
HyperWalletLibrary )
.) *
Model* /
./ 0
Payment0 7
payment8 ?
)? @
{ 	
Token 
= 
payment 
. 
Token !
;! "
Amount 
= 
payment 
. 
Amount #
;# $
Id 
= 
payment 
. 
ClientPaymentId (
;( )
DestinationToken 
= 
payment &
.& '
DestinationToken' 7
;7 8
	ExpiresOn 
= 
payment 
.  
	ExpiresOn  )
;) *
Notes 
= 
payment 
. 
Notes !
;! "
} 	
} 
} œ
SC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Database\Model\User.cs
	namespace 	
Server
 
. 
Database 
. 
Model 
{ 
[ 
Serializable 
] 
public 

class 
User 
: 
IModel 
{ 
public 
string 
Token 
{ 
get !
;! "
set# &
;& '
}( )
public		 
string		 
Id		 
{		 
get		 
;		 
set		  #
;		# $
}		% &
public

 
string

 
AddressLine1

 "
{

# $
get

% (
;

( )
set

* -
;

- .
}

/ 0
public 
string 
City 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
Country 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
	FirstName 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
LastName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 

MiddleName  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
string 
PhoneNumber !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 

PostalCode  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
string 
StateProvince #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
User 
( 
) 
{ 
} 
public 
User 
( 
HyperWalletLibrary &
.& '
Model' ,
., -
User- 1
apiUser2 9
)9 :
{ 	
Token 
= 
apiUser 
. 
Token !
;! "
Id 
= 
apiUser 
. 
ClientUserId %
;% &
AddressLine1 
= 
apiUser "
." #
AddressLine1# /
;/ 0
City 
= 
apiUser 
. 
City 
;  
Country 
= 
apiUser 
. 
Country %
;% &
Email 
= 
apiUser 
. 
Email !
;! "
	FirstName 
= 
apiUser 
.  
	FirstName  )
;) *
LastName 
= 
apiUser 
. 
LastName '
;' (

MiddleName   
=   
apiUser    
.    !

MiddleName  ! +
;  + ,
PhoneNumber!! 
=!! 
apiUser!! !
.!!! "
PhoneNumber!!" -
;!!- .

PostalCode"" 
="" 
apiUser""  
.""  !

PostalCode""! +
;""+ ,
StateProvince## 
=## 
apiUser## #
.### $
StateProvince##$ 1
;##1 2
}$$ 	
}%% 
}&& ß
^C:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Database\PaymentDatabaseWorker.cs
	namespace 	
Server
 
. 
Database 
{		 
public

 

class

 !
PaymentDatabaseWorker

 &
:

' (
IDatabaseWorker

) 8
<

8 9
Payment

9 @
>

@ A
{ 
private 
readonly 
Context  
_context! )
;) *
public !
PaymentDatabaseWorker $
($ %
Context% ,
context- 4
)4 5
{ 	
_context 
= 
context 
; 
} 	
public 
async 
Task 
< 
List 
< 
Payment &
>& '
>' (
GetAsync) 1
(1 2
)2 3
{ 	
return 
await 
Task 
. 
Run !
(! "
(" #
)# $
=>% '
{ 
try 
{ 
return 
_context #
.# $
Payments$ ,
?, -
.- .
ToList. 4
(4 5
)5 6
;6 7
} 
catch 
( 
	Exception  
)  !
{ 
return 
null 
;  
} 
} 
) 
; 
}   	
public"" 
async"" 
Task"" 
<"" 
Payment"" !
>""! "
GetAsync""# +
(""+ ,
string"", 2
id""3 5
)""5 6
{## 	
return$$ 
await$$ 
Task$$ 
.$$ 
Run$$ !
($$! "
($$" #
)$$# $
=>$$% '
{%% 
try&& 
{'' 
return(( 
_context(( #
.((# $
Payments(($ ,
?((, -
.((- .
FirstOrDefault((. <
(((< =
el((= ?
=>((@ B
el((C E
.((E F
Id((F H
==((I K
id((L N
)((N O
;((O P
})) 
catch** 
(** 
	Exception**  
)**  !
{++ 
return,, 
null,, 
;,,  
}-- 
}.. 
).. 
;.. 
}// 	
public11 
async11 
Task11 
<11 
bool11 
>11 
	PostAsync11  )
(11) *
Payment11* 1
item112 6
)116 7
{22 	
return33 
await33 
Task33 
.33 
Run33 !
(33! "
(33" #
)33# $
=>33% '
{44 
try55 
{66 
_context77 
.77 
Payments77 %
.77% &
Add77& )
(77) *
item77* .
)77. /
;77/ 0
_context88 
.88 
SaveChanges88 (
(88( )
)88) *
;88* +
return99 
true99 
;99  
}:: 
catch;; 
(;; 
	Exception;;  
);;  !
{<< 
return== 
false==  
;==  !
}>> 
}?? 
)?? 
;?? 
}@@ 	
publicBB 
TaskBB 
<BB 
boolBB 
>BB 
PutAsyncBB "
(BB" #
stringBB# )
idBB* ,
,BB, -
PaymentBB. 5
valueBB6 ;
)BB; <
{CC 	
returnDD 
nullDD 
;DD 
}EE 	
}FF 
}GG ¢5
[C:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Database\UpdateDatabaseTask.cs
	namespace 	
Server
 
. 
Database 
{ 
public 

class 
UpdateDatabaseTask #
:$ %
IHostedService& 4
{ 
private 
const 
int 
SLEEP 
=  !
$num" $
*% &
$num' )
** +
$num, 0
;0 1
private 
readonly 
IDatabaseWorker (
<( )
User) -
>- .
_databaseUserWorker/ B
;B C
private 
readonly 
IDatabaseWorker (
<( )
Payment) 0
>0 1"
_databasePaymentWorker2 H
;H I
private 
readonly 

IApiWorker #
<# $
User$ (
>( )
_apiUserWorker* 8
;8 9
private 
readonly 

IApiWorker #
<# $
Payment$ +
>+ ,
_apiPaymentWorker- >
;> ?
private 
bool 
Stoped 
{ 
get !
;! "
set# &
;& '
}( )
public 
UpdateDatabaseTask !
(! "
)" #
{ 	
string 
connectionString #
=$ %
$str	& ¸
;
¸ ˝#
DbContextOptionsBuilder #
<# $
Context$ +
>+ ,
options- 4
=5 6
new7 :#
DbContextOptionsBuilder; R
<R S
ContextS Z
>Z [
([ \
)\ ]
;] ^
options 
. 
UseSqlServer  
(  !
connectionString! 1
)1 2
;2 3
Context 
context 
= 
new !
Context" )
() *
options* 1
.1 2
Options2 9
)9 :
;: ;
_databaseUserWorker 
=  !
new" %
UserDatabaseWorker& 8
(8 9
context9 @
)@ A
;A B
_apiUserWorker 
= 
new  
UserApiWorker! .
(. /
)/ 0
;0 1"
_databasePaymentWorker "
=# $
new% (!
PaymentDatabaseWorker) >
(> ?
context? F
)F G
;G H
_apiPaymentWorker   
=   
new    #
PaymentApiWorker  $ 4
(  4 5
)  5 6
;  6 7
}!! 	
public## 
Task## 

StartAsync## 
(## 
CancellationToken## 0
cancellationToken##1 B
)##B C
{$$ 	
return%% 
Task%% 
.%% 
Run%% 
(%% 
(%% 
)%% 
=>%% !
{&& 
Stoped'' 
='' 
false'' 
;'' 
while(( 
((( 
!(( 
Stoped(( 
)(( 
{)) 
UpdateDatabase** "
(**" #
)**# $
;**$ %
Thread++ 
.++ 
Sleep++  
(++  !
SLEEP++! &
)++& '
;++' (
},, 
}-- 
)-- 
;-- 
}.. 	
public00 
Task00 
	StopAsync00 
(00 
CancellationToken00 /
cancellationToken000 A
)00A B
{11 	
return22 
Task22 
.22 
Run22 
(22 
(22 
)22 
=>22 !
{33 
Stoped44 
=44 
true44 
;44 
}55 
)55 
;55 
}66 	
private88 
async88 
void88 
UpdateDatabase88 )
(88) *
)88* +
{99 	
List:: 
<:: 
User:: 
>:: 
userApi:: 
=::  
await::! &
_apiUserWorker::' 5
.::5 6
GetAsync::6 >
(::> ?
)::? @
;::@ A
List;; 
<;; 
Payment;; 
>;; 

paymentApi;; $
=;;% &
await;;' ,
_apiPaymentWorker;;- >
.;;> ?
GetAsync;;? G
(;;G H
);;H I
;;;I J
List<< 
<<< 
User<< 
><< 
userDatabase<< #
=<<$ %
await<<& +
_databaseUserWorker<<, ?
.<<? @
GetAsync<<@ H
(<<H I
)<<I J
;<<J K
List== 
<== 
Payment== 
>== 
paymentDatabase== )
===* +
await==, 1"
_databasePaymentWorker==2 H
.==H I
GetAsync==I Q
(==Q R
)==R S
;==S T
foreach>> 
(>> 
User>> 
user>> 
in>> !
userApi>>" )
)>>) *
{?? 
User@@ 
search@@ 
=@@ 
userDatabase@@ *
.@@* +
FirstOrDefault@@+ 9
(@@9 :
el@@: <
=>@@= ?
el@@@ B
.@@B C
Token@@C H
==@@I K
user@@L P
.@@P Q
Token@@Q V
)@@V W
;@@W X
ifAA 
(AA 
searchAA 
==AA 
nullAA "
)AA" #
{BB 
awaitCC 
_databaseUserWorkerCC -
.CC- .
	PostAsyncCC. 7
(CC7 8
userCC8 <
)CC< =
;CC= >
continueDD 
;DD 
}EE 
awaitGG 
_databaseUserWorkerGG )
.GG) *
PutAsyncGG* 2
(GG2 3
searchGG3 9
.GG9 :
IdGG: <
,GG< =
userGG> B
)GGB C
;GGC D
}HH 
foreachII 
(II 
PaymentII 
userII !
inII" $

paymentApiII% /
)II/ 0
{JJ 
PaymentKK 
searchKK 
=KK  
paymentDatabaseKK! 0
.KK0 1
FirstOrDefaultKK1 ?
(KK? @
elKK@ B
=>KKC E
elKKF H
.KKH I
TokenKKI N
==KKO Q
userKKR V
.KKV W
TokenKKW \
)KK\ ]
;KK] ^
ifLL 
(LL 
searchLL 
==LL 
nullLL "
)LL" #
awaitMM "
_databasePaymentWorkerMM 0
.MM0 1
	PostAsyncMM1 :
(MM: ;
userMM; ?
)MM? @
;MM@ A
}NN 
}OO 	
}PP 
}QQ è+
[C:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Database\UserDatabaseWorker.cs
	namespace		 	
Server		
 
.		 
Database		 
{

 
public 

class 
UserDatabaseWorker #
:$ %
IDatabaseWorker& 5
<5 6
User6 :
>: ;
{ 
private 
readonly 
Context  
_context! )
;) *
public 
UserDatabaseWorker !
(! "
Context" )
context* 1
)1 2
{ 	
_context 
= 
context 
; 
} 	
public 
async 
Task 
< 
List 
< 
User #
># $
>$ %
GetAsync& .
(. /
)/ 0
{ 	
return 
await 
Task 
. 
Run !
(! "
(" #
)# $
=>% '
{ 
try 
{ 
return 
_context #
.# $
Users$ )
?) *
.* +
ToList+ 1
(1 2
)2 3
;3 4
} 
catch 
( 
	Exception  
)  !
{ 
return 
null 
;  
} 
}   
)   
;   
}!! 	
public## 
async## 
Task## 
<## 
User## 
>## 
GetAsync##  (
(##( )
string##) /
clientUserId##0 <
)##< =
{$$ 	
return%% 
await%% 
Task%% 
.%% 
Run%% !
(%%! "
(%%" #
)%%# $
=>%%% '
{&& 
try'' 
{(( 
return)) 
_context)) #
.))# $
Users))$ )
?))) *
.))* +
FirstOrDefault))+ 9
())9 :
el)): <
=>))= ?
el))@ B
.))B C
Id))C E
==))F H
clientUserId))I U
)))U V
;))V W
}** 
catch++ 
(++ 
	Exception++  
)++  !
{,, 
return-- 
null-- 
;--  
}.. 
}// 
)// 
;// 
}00 	
public22 
async22 
Task22 
<22 
bool22 
>22 
	PostAsync22  )
(22) *
User22* .
item22/ 3
)223 4
{33 	
return44 
await44 
Task44 
.44 
Run44 !
(44! "
(44" #
)44# $
=>44% '
{55 
try66 
{77 
_context88 
.88 
Users88 "
.88" #
Add88# &
(88& '
item88' +
)88+ ,
;88, -
_context99 
.99 
SaveChanges99 (
(99( )
)99) *
;99* +
return:: 
true:: 
;::  
};; 
catch<< 
(<< 
	Exception<<  
)<<  !
{== 
return>> 
false>>  
;>>  !
}?? 
}@@ 
)@@ 
;@@ 
}AA 	
publicCC 
asyncCC 
TaskCC 
<CC 
boolCC 
>CC 
PutAsyncCC  (
(CC( )
stringCC) /
clientUserIdCC0 <
,CC< =
UserCC> B
itemCCC G
)CCG H
{DD 	
returnEE 
awaitEE 
TaskEE 
.EE 
RunEE !
(EE! "
(EE" #
)EE# $
=>EE% '
{FF 
tryGG 
{HH 
UserII 
userII 
=II 
_contextII  (
.II( )
UsersII) .
?II. /
.II/ 0
FirstOrDefaultII0 >
(II> ?
elII? A
=>IIB D
elIIE G
.IIG H
IdIIH J
==IIK M
clientUserIdIIN Z
)IIZ [
;II[ \
ifJJ 
(JJ 
userJJ 
==JJ 
nullJJ  $
)JJ$ %
returnKK 
falseKK $
;KK$ %
foreachLL 
(LL 
PropertyInfoLL )
propertyLL* 2
inLL3 5
typeofLL6 <
(LL< =
UserLL= A
)LLA B
.LLB C
GetPropertiesLLC P
(LLP Q
)LLQ R
)LLR S
{MM 
objectNN 
valueNN $
=NN% &
propertyNN' /
.NN/ 0
GetValueNN0 8
(NN8 9
itemNN9 =
)NN= >
;NN> ?
ifOO 
(OO 
valueOO !
==OO" $
nullOO% )
)OO) *
breakPP !
;PP! "
propertyQQ  
.QQ  !
SetValueQQ! )
(QQ) *
userQQ* .
,QQ. /
valueQQ0 5
)QQ5 6
;QQ6 7
}RR 
_contextTT 
.TT 
SaveChangesTT (
(TT( )
)TT) *
;TT* +
returnUU 
trueUU 
;UU  
}VV 
catchWW 
(WW 
	ExceptionWW  
)WW  !
{XX 
returnYY 
falseYY  
;YY  !
}ZZ 
}[[ 
)[[ 
;[[ 
}\\ 	
}]] 
}^^ º
TC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Hubs\NotificationHub.cs
	namespace 	
Server
 
. 
Hubs 
{ 
public 

class 
NotificationHub  
:  !
Hub" %
{ 
} 
} Á
GC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Program.cs
	namespace 	
Server
 
{ 
public 

class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{ 	 
CreateWebHostBuilder  
(  !
args! %
)% &
.& '
Build' ,
(, -
)- .
.. /
Run/ 2
(2 3
)3 4
;4 5
} 	
public 
static 
IWebHostBuilder % 
CreateWebHostBuilder& :
(: ;
string; A
[A B
]B C
argsD H
)H I
=>J L
WebHost 
.  
CreateDefaultBuilder (
(( )
args) -
)- .
. 

UseStartup 
< 
Startup #
># $
($ %
)% &
;& '
} 
} á
VC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Service\AccountService.cs
	namespace 	
Server
 
. 
Service 
{ 
public 

class 
AccountService 
:  !
IAccountService" 1
{		 
private

 
readonly

 
IUserService

 %
_service

& .
;

. /
private 
readonly 
ITokenConverter (
<( )
User) -
>- .
_tokenConverter/ >
;> ?
public 
AccountService 
( 
Context %
context& -
)- .
{ 	
_service 
= 
new 
UserService &
(& '
context' .
). /
;/ 0
_tokenConverter 
= 
new ! 
TokenToUserConverter" 6
(6 7
)7 8
;8 9
} 	
public 
async 
Task 
< 
bool 
> 
RegistrateAsync  /
(/ 0
string0 6
token7 <
)< =
{ 	
_tokenConverter 
. 
Content #
=$ %
token& +
;+ ,
User 
user 
= 
_tokenConverter '
.' (
Convert( /
(/ 0
)0 1
;1 2
user 
. 
AddressLine1 
= 
$str  )
;) *
user 
. 
City 
= 
$str !
;! "
user 
. 

PostalCode 
= 
$str '
;' (
user 
. 
StateProvince 
=  
$str! *
;* +
user 
. 
Country 
= 
$str 
;  
bool 
result 
= 
await 
_service  (
.( )
Post) -
(- .
user. 2
)2 3
;3 4
return 
result 
; 
} 	
} 
}   Ÿ
WC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Service\IAccountService.cs
	namespace 	
Server
 
. 
Service 
{ 
public 

	interface 
IAccountService $
{ 
Task 
< 
bool 
> 
RegistrateAsync "
(" #
string# )
token* /
)/ 0
;0 1
} 
}		 Å
SC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Service\IApiService.cs
	namespace 	
Server
 
. 
Service 
{ 
public 

	interface 
IApiService  
<  !
T! "
>" #
where$ )
T* +
:, -
IModel. 4
{ 
Task		 
<		 
List		 
<		 
T		 
>		 
>		 
Get		 
(		 
)		 
;		 
Task

 
<

 
T

 
>

 
Get

 
(

 
string

 
id

 
)

 
;

 
Task 
< 
bool 
> 
Post 
( 
T 
value 
)  
;  !
} 
} Å
WC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Service\IPaymentService.cs
	namespace 	
Server
 
. 
Service 
{ 
public 

	interface 
IPaymentService $
:% &
IApiService' 2
<2 3
Payment3 :
>: ;
{ 
} 
} ≠
UC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Service\ITokenService.cs
	namespace 	
Server
 
. 
Service 
{ 
public 

	interface 
ITokenService "
{ 
Task 
< 
Token 
> 
GetTokenAsync !
(! "
)" #
;# $
}		 
}

 ÷
TC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Service\IUserService.cs
	namespace 	
Server
 
. 
Service 
{ 
public 

	interface 
IUserService !
:" #
IApiService$ /
</ 0
User0 4
>4 5
{ 
Task		 
<		 
bool		 
>		 
Put		 
(		 
string		 
clientId		 &
,		& '
User		( ,
value		- 2
)		2 3
;		3 4
}

 
} ƒ
SC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Service\Model\Token.cs
	namespace 	
Server
 
. 
Service 
. 
Model 
{ 
public 

class 
Token 
{ 
[ 	
JsonProperty	 
( 
$str $
)$ %
]% &
public 
string 
Access_Token "
{# $
get% (
;( )
set* -
;- .
}/ 0
[		 	
JsonProperty			 
(		 
$str		 "
)		" #
]		# $
public

 
string

 

Token_Type

  
{

! "
get

# &
;

& '
set

( +
;

+ ,
}

- .
} 
} ˘
VC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Service\PaymentService.cs
	namespace 	
Server
 
. 
Service 
{		 
public

 

class

 
PaymentService

 
:

  !
IPaymentService

" 1
{ 
private 
readonly 
IDatabaseWorker (
<( )
Payment) 0
>0 1
_databaseWorker2 A
;A B
private 
readonly 

IApiWorker #
<# $
Payment$ +
>+ ,

_apiWorker- 7
;7 8
public 
PaymentService 
( 
Context %
context& -
)- .
{ 	
_databaseWorker 
= 
new !!
PaymentDatabaseWorker" 7
(7 8
context8 ?
)? @
;@ A

_apiWorker 
= 
new 
PaymentApiWorker -
(- .
). /
;/ 0
} 	
public 
async 
Task 
< 
List 
< 
Payment &
>& '
>' (
Get) ,
(, -
)- .
{ 	
List 
< 
Payment 
> 
list 
=  
await! &
_databaseWorker' 6
.6 7
GetAsync7 ?
(? @
)@ A
;A B
return 
list 
; 
} 	
public 
async 
Task 
< 
Payment !
>! "
Get# &
(& '
string' -
id. 0
)0 1
{ 	
Payment 
payment 
= 
await #
_databaseWorker$ 3
.3 4
GetAsync4 <
(< =
id= ?
)? @
;@ A
return 
payment 
; 
} 	
public!! 
async!! 
Task!! 
<!! 
bool!! 
>!! 
Post!!  $
(!!$ %
Payment!!% ,
value!!- 2
)!!2 3
{"" 	
Payment## 
payment## 
=## 
await## #

_apiWorker##$ .
.##. /
	PostAsync##/ 8
(##8 9
value##9 >
)##> ?
;##? @
if$$ 
($$ 
payment$$ 
==$$ 
null$$ 
)$$  
return%% 
false%% 
;%% 
bool&& 
result&& 
=&& 
await&& 
_databaseWorker&&  /
.&&/ 0
	PostAsync&&0 9
(&&9 :
payment&&: A
)&&A B
;&&B C
return'' 
result'' 
;'' 
}(( 	
})) 
}** ø(
TC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Service\TokenService.cs
	namespace 	
Server
 
. 
Service 
{		 
public

 

class

 
TokenService

 
:

 
ITokenService

  -
{ 
private 
const 
string 
ADDRESS $
=% &
$str' T
;T U
private 
const 
string 
	CLIENT_ID &
=' (
$str) K
;K L
private 
const 
string 
CLIENT_SECRET *
=+ ,
$str- o
;o p
private 
const 
string 
AUDIENCE %
=& '
$str( H
;H I
private 
const 
string 

GRANT_TYPE '
=( )
$str* >
;> ?
private 
readonly 

HttpClient #
_client$ +
;+ ,
public 
TokenService 
( 
) 
{ 	
_client 
= 
new 

HttpClient $
($ %
)% &
;& '
} 	
public 
async 
Task 
< 
Token 
>  
GetTokenAsync! .
(. /
)/ 0
{ 	
try 
{ 
string 
json 
= 
GenerateJson *
(* +
)+ ,
;, -
HttpContent 
content #
=$ %
new& )
StringContent* 7
(7 8
json8 <
,< =
null> B
,B C
$strD V
)V W
;W X
HttpResponseMessage #
response$ ,
=- .
await/ 4
_client5 <
.< =
	PostAsync= F
(F G
ADDRESSG N
,N O
contentP W
)W X
;X Y
string   
responseContent   &
=  ' (
await  ) .
response  / 7
.  7 8
Content  8 ?
.  ? @
ReadAsStringAsync  @ Q
(  Q R
)  R S
;  S T
Token!! 
token!! 
=!! 
JsonConvert!! )
.!!) *
DeserializeObject!!* ;
<!!; <
Token!!< A
>!!A B
(!!B C
responseContent!!C R
)!!R S
;!!S T
return"" 
token"" 
;"" 
}## 
catch$$ 
($$ 
	Exception$$ 
)$$ 
{%% 
return&& 
null&& 
;&& 
}'' 
}(( 	
private** 
string** 
GenerateJson** #
(**# $
)**$ %
{++ 	
StringWriter,, 
json,, 
=,, 
new,,  #
StringWriter,,$ 0
(,,0 1
),,1 2
;,,2 3

JsonWriter-- 

jsonWriter-- !
=--" #
new--$ '
JsonTextWriter--( 6
(--6 7
json--7 ;
)--; <
;--< =

jsonWriter.. 
... 
WriteStartObject.. '
(..' (
)..( )
;..) *

jsonWriter// 
.// 
WritePropertyName// (
(//( )
nameof//) /
(/// 0
	CLIENT_ID//0 9
)//9 :
.//: ;
ToLower//; B
(//B C
)//C D
)//D E
;//E F

jsonWriter00 
.00 

WriteValue00 !
(00! "
	CLIENT_ID00" +
)00+ ,
;00, -

jsonWriter11 
.11 
WritePropertyName11 (
(11( )
nameof11) /
(11/ 0
CLIENT_SECRET110 =
)11= >
.11> ?
ToLower11? F
(11F G
)11G H
)11H I
;11I J

jsonWriter22 
.22 

WriteValue22 !
(22! "
CLIENT_SECRET22" /
)22/ 0
;220 1

jsonWriter33 
.33 
WritePropertyName33 (
(33( )
nameof33) /
(33/ 0
AUDIENCE330 8
)338 9
.339 :
ToLower33: A
(33A B
)33B C
)33C D
;33D E

jsonWriter44 
.44 

WriteValue44 !
(44! "
AUDIENCE44" *
)44* +
;44+ ,

jsonWriter55 
.55 
WritePropertyName55 (
(55( )
nameof55) /
(55/ 0

GRANT_TYPE550 :
)55: ;
.55; <
ToLower55< C
(55C D
)55D E
)55E F
;55F G

jsonWriter66 
.66 

WriteValue66 !
(66! "

GRANT_TYPE66" ,
)66, -
;66- .

jsonWriter77 
.77 
WriteEnd77 
(77  
)77  !
;77! "
return88 
json88 
.88 
ToString88  
(88  !
)88! "
;88" #
}99 	
}:: 
};; Ó
SC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Service\UserService.cs
	namespace 	
Server
 
. 
Service 
{		 
public

 

class

 
UserService

 
:

 
IUserService

 +
{ 
private 
readonly 
IDatabaseWorker (
<( )
User) -
>- .
_databaseWorker/ >
;> ?
private 
readonly 

IApiWorker #
<# $
User$ (
>( )

_apiWorker* 4
;4 5
public 
UserService 
( 
Context "
context# *
)* +
{ 	
_databaseWorker 
= 
new !
UserDatabaseWorker" 4
(4 5
context5 <
)< =
;= >

_apiWorker 
= 
new 
UserApiWorker *
(* +
)+ ,
;, -
} 	
public 
async 
Task 
< 
List 
< 
User #
># $
>$ %
Get& )
() *
)* +
{ 	
List 
< 
User 
> 
list 
= 
await #
_databaseWorker$ 3
.3 4
GetAsync4 <
(< =
)= >
;> ?
return 
list 
; 
} 	
public 
async 
Task 
< 
User 
> 
Get  #
(# $
string$ *
clientId+ 3
)3 4
{ 	
User 
user 
= 
await 
_databaseWorker -
.- .
GetAsync. 6
(6 7
clientId7 ?
)? @
;@ A
return 
user 
; 
} 	
public!! 
async!! 
Task!! 
<!! 
bool!! 
>!! 
Post!!  $
(!!$ %
User!!% )
value!!* /
)!!/ 0
{"" 	
User## 
user## 
=## 
await## 

_apiWorker## (
.##( )
	PostAsync##) 2
(##2 3
value##3 8
)##8 9
;##9 :
if$$ 
($$ 
user$$ 
==$$ 
null$$ 
)$$ 
return%% 
false%% 
;%% 
bool&& 
result&& 
=&& 
await&& 
_databaseWorker&&  /
.&&/ 0
	PostAsync&&0 9
(&&9 :
user&&: >
)&&> ?
;&&? @
return'' 
result'' 
;'' 
}(( 	
public** 
async** 
Task** 
<** 
bool** 
>** 
Put**  #
(**# $
string**$ *
clientId**+ 3
,**3 4
User**5 9
value**: ?
)**? @
{++ 	
User,, 
data,, 
=,, 
await,, 
_databaseWorker,, -
.,,- .
GetAsync,,. 6
(,,6 7
clientId,,7 ?
),,? @
;,,@ A
User-- 
user-- 
=-- 
await-- 

_apiWorker-- (
.--( )
PutAsync--) 1
(--1 2
data--2 6
.--6 7
Token--7 <
,--< =
value--> C
)--C D
;--D E
if.. 
(.. 
user.. 
==.. 
null.. 
).. 
return// 
false// 
;// 
bool00 
result00 
=00 
await00 
_databaseWorker00  /
.00/ 0
PutAsync000 8
(008 9
clientId009 A
,00A B
user00C G
)00G H
;00H I
return11 
result11 
;11 
}22 	
}33 
}44 Õ
GC:\Users\vlad1\source\repos\HyperWalletLibrary\Server\Server\Startup.cs
	namespace 	
Server
 
{ 
public 

class 
Startup 
{ 
public 
Startup 
( 
IConfiguration %
configuration& 3
)3 4
{ 	
Configuration 
= 
configuration )
;) *
} 	
public 
IConfiguration 
Configuration +
{, -
get. 1
;1 2
}3 4
public 
void 
ConfigureServices %
(% &
IServiceCollection& 8
services9 A
)A B
{ 	
string 

connection 
= 
Configuration  -
.- .
GetConnectionString. A
(A B
$strB U
)U V
;V W
services 
. 
AddDbContext !
<! "
Context" )
>) *
(* +
options+ 2
=>3 5
options6 =
.= >
UseSqlServer> J
(J K

connectionK U
)U V
)V W
;W X
services 
. 
AddAuthentication &
(& '
options' .
=>/ 1
{ 
options 
. %
DefaultAuthenticateScheme 5
=6 7
JwtBearerDefaults8 I
.I J 
AuthenticationSchemeJ ^
;^ _
options   
.   "
DefaultChallengeScheme   2
=  3 4
JwtBearerDefaults  5 F
.  F G 
AuthenticationScheme  G [
;  [ \
}!! 
)!! 
.!! 
AddJwtBearer!! 
(!!  
options!!  '
=>!!( *
{"" 
options## 
.## 
	Authority## %
=##& '
Configuration##( 5
[##5 6
$str##6 D
]##D E
;##E F
options$$ 
.$$ 
Audience$$ $
=$$% &
Configuration$$' 4
[$$4 5
$str$$5 J
]$$J K
;$$K L
}%% 
)%% 
;%% 
services&& 
.&& 

AddSignalR&& 
(&&  
)&&  !
;&&! "
services'' 
.'' 
AddMvc'' 
('' 
)'' 
.'' #
SetCompatibilityVersion'' 5
(''5 6 
CompatibilityVersion''6 J
.''J K
Version_2_1''K V
)''V W
;''W X
services(( 
.(( 
AddHostedService(( %
<((% &
UpdateDatabaseTask((& 8
>((8 9
(((9 :
)((: ;
;((; <
})) 	
public++ 
void++ 
	Configure++ 
(++ 
IApplicationBuilder++ 1
app++2 5
,++5 6
IHostingEnvironment++7 J
env++K N
)++N O
{,, 	
if-- 
(-- 
env-- 
.-- 
IsDevelopment-- !
(--! "
)--" #
)--# $
{.. 
app// 
.// %
UseDeveloperExceptionPage// -
(//- .
)//. /
;/// 0
}00 
app22 
.22 
UseAuthentication22 !
(22! "
)22" #
;22# $
app33 
.33 

UseSignalR33 
(33 
options33 "
=>33# %
{33& '
options33( /
.33/ 0
MapHub330 6
<336 7
NotificationHub337 F
>33F G
(33G H
$str33H W
)33W X
;33X Y
}33Z [
)33[ \
;33\ ]
app44 
.44 
UseMvc44 
(44 
)44 
;44 
}55 	
}66 
}77 