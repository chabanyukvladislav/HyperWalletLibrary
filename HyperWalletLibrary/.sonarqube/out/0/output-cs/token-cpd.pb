≥\
rC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Api\AbstractHyperWalletApi.cs
	namespace 	
HyperWalletLibrary
 
. 
Api  
{ 
public 

class "
AbstractHyperWalletApi '
<' (
T( )
>) *
where+ 0
T1 2
:3 4
IHyperWalletModel5 F
{		 
private

 
const

 
string

 
MAIN_ADDRESS

 )
=

* +
$str

, [
;

[ \
	protected 
readonly 
IHyperWalletSender -
<- .
T. /
>/ 0
_sender1 8
;8 9
	protected 
HttpResponseMessage %
	_response& /
;/ 0
	protected 
IHyperWalletAccount %
_account& .
;. /
private 
string 
Address 
{  
get! $
;$ %
set& )
;) *
}+ ,
	protected "
AbstractHyperWalletApi (
(( )
string) /
type0 4
,4 5
string6 <
token= B
,B C
stringD J
localAddressK W
,W X
IHyperWalletAccountY l
accountm t
)t u
{ 	
Address 
= 
GenerateAddress %
(% &
type& *
,* +
token, 1
,1 2
localAddress3 ?
)? @
;@ A
_sender 
= 
new 
HyperWalletSender +
<+ ,
T, -
>- .
(. /
account/ 6
)6 7
;7 8
_account 
= 
account 
; 
} 	
public 
virtual 
async 
Task !
<! "
Response" *
<* +
T+ ,
>, -
>- .
GetAsync/ 7
(7 8
)8 9
{ 	
	_response 
= 
await 
_sender %
.% &
GetAsync& .
(. /
Address/ 6
)6 7
;7 8
if 
( 
! 
	_response 
. 
IsSuccessStatusCode .
). /
throw 
new  
HttpRequestException .
(. /
$str/ \
+] ^
	_response_ h
.h i

StatusCodei s
)s t
;t u*
IGetterFromHttpResponseMessage *
<* +
Response+ 3
<3 4
T4 5
>5 6
>6 7
getter8 >
=? @
newA D)
ContentFromHttpResponseGetterE b
<b c
Responsec k
<k l
Tl m
>m n
>n o
(o p
	_responsep y
)y z
;z {
Response 
< 
T 
> 
result 
=  
await! &
getter' -
.- .
GetAsync. 6
(6 7
)7 8
;8 9
if   
(   
result   
.   
Count   
>   
$num   !
)  ! "
result!! 
=!! 
await!! 
GetAll!! %
(!!% &
result!!& ,
)!!, -
;!!- .
return"" 
result"" 
;"" 
}## 	
public%% 
virtual%% 
async%% 
Task%% !
<%%! "
T%%" #
>%%# $
GetAsync%%% -
(%%- .
string%%. 4
token%%5 :
)%%: ;
{&& 	
GenerateAddress'' 
('' 
token'' !
)''! "
;''" #
	_response(( 
=(( 
await(( 
_sender(( %
.((% &
GetAsync((& .
(((. /
Address((/ 6
)((6 7
;((7 8
if)) 
()) 
!)) 
	_response)) 
.)) 
IsSuccessStatusCode)) .
))). /
throw** 
new**  
HttpRequestException** .
(**. /
$str**/ \
+**] ^
	_response**_ h
.**h i

StatusCode**i s
)**s t
;**t u*
IGetterFromHttpResponseMessage++ *
<++* +
T+++ ,
>++, -
getter++. 4
=++5 6
new++7 :)
ContentFromHttpResponseGetter++; X
<++X Y
T++Y Z
>++Z [
(++[ \
	_response++\ e
)++e f
;++f g
return,, 
await,, 
getter,, 
.,,  
GetAsync,,  (
(,,( )
),,) *
;,,* +
}-- 	
public.. 
virtual.. 
async.. 
Task.. !
<..! "
T.." #
>..# $
	PostAsync..% .
(... /
T../ 0
item..1 5
)..5 6
{// 	
GenerateAddress00 
(00 
)00 
;00 
	_response11 
=11 
await11 
_sender11 %
.11% &
	PostAsync11& /
(11/ 0
Address110 7
,117 8
item119 =
)11= >
;11> ?
if22 
(22 
!22 
	_response22 
.22 
IsSuccessStatusCode22 .
)22. /
throw33 
new33  
HttpRequestException33 .
(33. /
$str33/ \
+33] ^
	_response33_ h
.33h i

StatusCode33i s
)33s t
;33t u*
IGetterFromHttpResponseMessage44 *
<44* +
T44+ ,
>44, -
getter44. 4
=445 6
new447 :)
ContentFromHttpResponseGetter44; X
<44X Y
T44Y Z
>44Z [
(44[ \
	_response44\ e
)44e f
;44f g
return55 
await55 
getter55 
.55  
GetAsync55  (
(55( )
)55) *
;55* +
}66 	
public77 
virtual77 
async77 
Task77 !
<77! "
T77" #
>77# $
PutAsync77% -
(77- .
string77. 4
token775 :
,77: ;
T77< =
item77> B
)77B C
{88 	
GenerateAddress99 
(99 
token99 !
)99! "
;99" #
	_response:: 
=:: 
await:: 
_sender:: %
.::% &
PutAsync::& .
(::. /
Address::/ 6
,::6 7
item::8 <
)::< =
;::= >
if;; 
(;; 
!;; 
	_response;; 
.;; 
IsSuccessStatusCode;; .
);;. /
throw<< 
new<<  
HttpRequestException<< .
(<<. /
$str<</ \
+<<] ^
	_response<<_ h
.<<h i

StatusCode<<i s
)<<s t
;<<t u*
IGetterFromHttpResponseMessage== *
<==* +
T==+ ,
>==, -
getter==. 4
===5 6
new==7 :)
ContentFromHttpResponseGetter==; X
<==X Y
T==Y Z
>==Z [
(==[ \
	_response==\ e
)==e f
;==f g
return>> 
await>> 
getter>> 
.>>  
GetAsync>>  (
(>>( )
)>>) *
;>>* +
}?? 	
privateAA 
stringAA 
GenerateAddressAA &
(AA& '
stringAA' -
typeAA. 2
,AA2 3
stringAA4 :
tokenAA; @
,AA@ A
stringAAB H
localAddressAAI U
)AAU V
{BB 	
ifCC 
(CC 
stringCC 
.CC 
IsNullOrWhiteSpaceCC )
(CC) *
typeCC* .
)CC. /
)CC/ 0
returnDD 
MAIN_ADDRESSDD #
;DD# $
ifEE 
(EE 
stringEE 
.EE 
IsNullOrWhiteSpaceEE )
(EE) *
tokenEE* /
)EE/ 0
)EE0 1
returnFF 
stringFF 
.FF 
FormatFF $
(FF$ %
$strFF% .
,FF. /
MAIN_ADDRESSFF0 <
,FF< =
typeFF> B
)FFB C
;FFC D
stringGG 
addressGG 
=GG 
stringGG #
.GG# $
FormatGG$ *
(GG* +
$strGG+ <
,GG< =
MAIN_ADDRESSGG> J
,GGJ K
typeGGL P
,GGP Q
tokenGGR W
,GGW X
localAddressGGY e
)GGe f
;GGf g
returnHH 
addressHH 
;HH 
}II 	
privateJJ 
voidJJ 
GenerateAddressJJ $
(JJ$ %
stringJJ% +
tokenJJ, 1
=JJ2 3
$strJJ4 6
)JJ6 7
{KK 	
ifLL 
(LL 
stringLL 
.LL 
IsNullOrWhiteSpaceLL )
(LL) *
tokenLL* /
)LL/ 0
)LL0 1
returnMM 
;MM 
AddressNN 
=NN 
stringNN 
.NN 
FormatNN #
(NN# $
$strNN$ ,
,NN, -
AddressNN. 5
,NN5 6
tokenNN7 <
)NN< =
;NN= >
}OO 	
privateQQ 
asyncQQ 
TaskQQ 
<QQ 
ResponseQQ #
<QQ# $
TQQ$ %
>QQ% &
>QQ& '
GetAllQQ( .
(QQ. /
ResponseQQ/ 7
<QQ7 8
TQQ8 9
>QQ9 :
resultQQ; A
)QQA B
{RR 	
forSS 
(SS 
intSS 
iSS 
=SS 
$numSS 
;SS 
iSS 
<SS  
resultSS! '
.SS' (
CountSS( -
;SS- .
iSS/ 0
+=SS1 3
$numSS4 6
)SS6 7
{TT 
stringUU 
addressUU 
=UU  
stringUU! '
.UU' (
FormatUU( .
(UU. /
$strUU/ ?
,UU? @
AddressUUA H
,UUH I
iUUJ K
)UUK L
;UUL M
	_responseVV 
=VV 
awaitVV !
_senderVV" )
.VV) *
GetAsyncVV* 2
(VV2 3
addressVV3 :
)VV: ;
;VV; <*
IGetterFromHttpResponseMessageWW .
<WW. /
ResponseWW/ 7
<WW7 8
TWW8 9
>WW9 :
>WW: ;
getterWW< B
=WWC D
newWWE H)
ContentFromHttpResponseGetterWWI f
<WWf g
ResponseWWg o
<WWo p
TWWp q
>WWq r
>WWr s
(WWs t
	_responseWWt }
)WW} ~
;WW~ 
ResponseXX 
<XX 
TXX 
>XX 
getXX 
=XX  !
awaitXX" '
getterXX( .
.XX. /
GetAsyncXX/ 7
(XX7 8
)XX8 9
;XX9 :
ifYY 
(YY 
getYY 
!=YY 
nullYY 
&&YY  "
getYY# &
.YY& '
DataYY' +
!=YY, .
nullYY/ 3
)YY3 4
foreachZZ 
(ZZ 
TZZ 
tZZ  
inZZ! #
getZZ$ '
.ZZ' (
DataZZ( ,
)ZZ, -
{[[ 
result\\ 
.\\ 
Data\\ #
.\\# $
Add\\$ '
(\\' (
t\\( )
)\\) *
;\\* +
result]] 
.]] 
Limit]] $
++]]$ &
;]]& '
}^^ 
}__ 
returnaa 
resultaa 
;aa 
}bb 	
}cc 
}dd ó
cC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Api\Payment.cs
	namespace 	
HyperWalletLibrary
 
. 
Api  
{ 
public 

class 
Payment 
: "
AbstractHyperWalletApi 0
<0 1
Model1 6
.6 7
Payment7 >
>> ?
{		 
private

 
const

 
string

 
TYPE

 !
=

" #
$str

$ /
;

/ 0
private 
const 
string 

USER_TOKEN '
=( )
$str* -
;- .
private 
const 
string 
LOCAL_ADDRESS *
=+ ,
$str- 0
;0 1
public 
Payment 
( 
IHyperWalletAccount *
account+ 2
)2 3
:4 5
base6 :
(: ;
TYPE; ?
,? @

USER_TOKENA K
,K L
LOCAL_ADDRESSM Z
,Z [
account\ c
)c d
{e f
}g h
public 
override 
async 
Task "
<" #
Response# +
<+ ,
Model, 1
.1 2
Payment2 9
>9 :
>: ;
GetAsync< D
(D E
)E F
{ 	
return 
await 
base 
. 
GetAsync &
(& '
)' (
;( )
} 	
public 
override 
async 
Task "
<" #
Model# (
.( )
Payment) 0
>0 1
GetAsync2 :
(: ;
string; A
tokenB G
)G H
{ 	
return 
await 
base 
. 
GetAsync &
(& '
token' ,
), -
;- .
} 	
public 
override 
async 
Task "
<" #
Model# (
.( )
Payment) 0
>0 1
	PostAsync2 ;
(; <
Model< A
.A B
PaymentB I
itemJ N
)N O
{ 	
item 
. 
ProgramToken 
= 
_account  (
.( )
Portal) /
./ 0
ProgramToken0 <
;< =
item 
. 
Purpose 
= 
$str "
;" #
item 
. 
Currency 
= 
$str !
;! "
item 
. 
ClientPaymentId  
=! "
new# &
Random' -
(- .
). /
./ 0
Next0 4
(4 5
)5 6
.6 7
ToString7 ?
(? @
)@ A
;A B
return   
await   
base   
.   
	PostAsync   '
(  ' (
item  ( ,
)  , -
;  - .
}!! 	
}"" 
}## ÿ
`C:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Api\User.cs
	namespace 	
HyperWalletLibrary
 
. 
Api  
{ 
public 

class 
User 
: "
AbstractHyperWalletApi .
<. /
Model/ 4
.4 5
User5 9
>9 :
{ 
private		 
const		 
string		 
TYPE		 !
=		" #
$str		$ ,
;		, -
private

 
const

 
string

 

USER_TOKEN

 '
=

( )
$str

* -
;

- .
private 
const 
string 
LOCAL_ADDRESS *
=+ ,
$str- 0
;0 1
public 
User 
( 
IHyperWalletAccount '
account( /
)/ 0
:1 2
base3 7
(7 8
TYPE8 <
,< =

USER_TOKEN> H
,H I
LOCAL_ADDRESSJ W
,W X
accountY `
)` a
{b c
}d e
public 
override 
async 
Task "
<" #
Response# +
<+ ,
Model, 1
.1 2
User2 6
>6 7
>7 8
GetAsync9 A
(A B
)B C
{ 	
return 
await 
base 
. 
GetAsync &
(& '
)' (
;( )
} 	
public 
override 
async 
Task "
<" #
Model# (
.( )
User) -
>- .
GetAsync/ 7
(7 8
string8 >
token? D
)D E
{ 	
return 
await 
base 
. 
GetAsync &
(& '
token' ,
), -
;- .
} 	
public 
override 
async 
Task "
<" #
Model# (
.( )
User) -
>- .
	PostAsync/ 8
(8 9
Model9 >
.> ?
User? C
itemD H
)H I
{ 	
item 
. 
ProfileType 
= 
ProfileTypes +
.+ ,

INDIVIDUAL, 6
;6 7
item 
. 
ProgramToken 
= 
_account  (
.( )
Portal) /
./ 0
ProgramToken0 <
;< =
return 
await 
base 
. 
	PostAsync '
(' (
item( ,
), -
;- .
} 	
public   
override   
async   
Task   "
<  " #
Model  # (
.  ( )
User  ) -
>  - .
PutAsync  / 7
(  7 8
string  8 >
token  ? D
,  D E
Model  F K
.  K L
User  L P
item  Q U
)  U V
{!! 	
return"" 
await"" 
base"" 
."" 
PutAsync"" &
(""& '
token""' ,
,"", -
item"". 2
)""2 3
;""3 4
}## 	
}$$ 
}%% å
ÄC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Components\ContentFromHttpResponseGetter.cs
	namespace 	
HyperWalletLibrary
 
. 

Components '
{ 
public 

class )
ContentFromHttpResponseGetter .
<. /
T/ 0
>0 1
:2 3*
IGetterFromHttpResponseMessage4 R
<R S
TS T
>T U
whereV [
T\ ]
:^ _
IHyperWalletModel` q
{		 
public

 
HttpResponseMessage

 "
Content

# *
{

+ ,
get

- 0
;

0 1
set

2 5
;

5 6
}

7 8
public 
async 
Task 
< 
T 
> 
GetAsync %
(% &
)& '
{ 	
if 
( 
Content 
== 
null 
)  
return! '
default( /
(/ 0
T0 1
)1 2
;2 3
string 
content 
= 
await "
Content# *
.* +
Content+ 2
.2 3
ReadAsStringAsync3 D
(D E
)E F
;F G
T 
data 
= 
JsonConvert  
.  !
DeserializeObject! 2
<2 3
T3 4
>4 5
(5 6
content6 =
)= >
;> ?
return 
data 
; 
} 	
public )
ContentFromHttpResponseGetter ,
(, -
HttpResponseMessage- @
contentA H
=I J
nullK O
)O P
{ 	
Content 
= 
content 
; 
} 	
} 
} è
kC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Components\HttpType.cs
	namespace 	
HyperWalletLibrary
 
. 

Components '
{ 
public 

enum 
HttpType 
{ 
Get 
, 
Post 
, 
Put 
} 
}		 ¡	
uC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Components\HyperWalletAccount.cs
	namespace 	
HyperWalletLibrary
 
. 

Components '
{ 
public 

class 
HyperWalletAccount #
:$ %
IHyperWalletAccount& 9
{ 
public 
IHyperWalletProgram "
Main# '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
IHyperWalletProgram "
Card# '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
IHyperWalletProgram "
Direct# )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
IHyperWalletProgram "
Portal# )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public		 
IHyperWalletProgram		 "
Select		# )
{		* +
get		, /
;		/ 0
set		1 4
;		4 5
}		6 7
}

 
} ⁄
uC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Components\HyperWalletProgram.cs
	namespace 	
HyperWalletLibrary
 
. 

Components '
{ 
public 

class 
HyperWalletProgram #
:$ %
IHyperWalletProgram& 9
{ 
public 
string 
Username 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Password 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
ProgramToken "
{# $
get% (
;( )
set* -
;- .
}/ 0
} 
}		 ≠E
tC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Components\HyperWalletSender.cs
	namespace

 	
HyperWalletLibrary


 
.

 

Components

 '
{ 
public 

class 
HyperWalletSender "
<" #
T# $
>$ %
:& '
IHyperWalletSender( :
<: ;
T; <
>< =
where> C
TD E
:F G
IHyperWalletModelH Y
{ 
private 
readonly 

HttpClient #
_client$ +
;+ ,
private 
HttpResponseMessage #
	_response$ -
;- .
private 
HttpContent 
_content $
;$ %
private 
IHyperWalletAccount #
_account$ ,
;, -
public 
HyperWalletSender  
(  !
IHyperWalletAccount! 4
account5 <
)< =
{ 	
HttpClientHandler 
handler %
=& '
new( +
HttpClientHandler, =
{ 
Credentials 
= 
new !
NetworkCredential" 3
(3 4
account4 ;
.; <
Portal< B
.B C
UsernameC K
,K L
accountM T
.T U
PortalU [
.[ \
Password\ d
)d e
} 
; 
_client 
= 
new 

HttpClient $
($ %
handler% ,
), -
;- .
_client 
. !
DefaultRequestHeaders )
.) *
Accept* 0
.0 1
Add1 4
(4 5
new5 8+
MediaTypeWithQualityHeaderValue9 X
(X Y
$strY k
)k l
)l m
;m n
_account 
= 
account 
; 
} 	
public 
async 
Task 
< 
HttpResponseMessage -
>- .
	SendAsync/ 8
(8 9
string9 ?
address@ G
,G H&
IHyperWalletSenderSettingsI c
<c d
Td e
>e f
settingsg o
)o p
{ 	
if   
(   
string   
.   
IsNullOrWhiteSpace   )
(  ) *
address  * 1
)  1 2
)  2 3
throw!! 
new!! !
ArgumentNullException!! /
(!!/ 0
$str!!0 R
)!!R S
;!!S T
switch"" 
("" 
settings"" 
."" 
Type"" !
)""! "
{## 
case$$ 
HttpType$$ 
.$$ 
Get$$ !
:$$! "
return%% 
await%%  
GetAsync%%! )
(%%) *
address%%* 1
)%%1 2
;%%2 3
case&& 
HttpType&& 
.&& 
Post&& "
:&&" #
return'' 
await''  
	PostAsync''! *
(''* +
address''+ 2
,''2 3
settings''4 <
.''< =
Data''= A
)''A B
;''B C
case(( 
HttpType(( 
.(( 
Put(( !
:((! "
return)) 
await))  
PutAsync))! )
())) *
address))* 1
,))1 2
settings))3 ;
.)); <
Data))< @
)))@ A
;))A B
default** 
:** 
throw++ 
new++ !
ArgumentNullException++ 3
(++3 4
$str++4 e
)++e f
;++f g
},, 
}-- 	
private// 
void// 
SerializeContent// %
(//% &
T//& '
data//( ,
)//, -
{00 	
if11 
(11 
data11 
==11 
null11 
)11 
throw22 
new22 !
ArgumentNullException22 /
(22/ 0
$str220 a
)22a b
;22b c
string33 
json33 
=33 
$str33 
;33 
json44 
=44 
JsonConvert44 
.44 
SerializeObject44 .
(44. /
data44/ 3
,443 4

Formatting445 ?
.44? @
None44@ D
,44D E
new44F I"
JsonSerializerSettings44J `
{44a b
NullValueHandling44c t
=44u v
NullValueHandling	44w à
.
44à â
Ignore
44â è
,
44è ê
DateFormatString
44ë °
=
44¢ £
$str
44§ π
}
44∫ ª
)
44ª º
;
44º Ω
_content55 
=55 
new55 
StringContent55 (
(55( )
json55) -
,55- .
Encoding55/ 7
.557 8
UTF8558 <
,55< =
$str55> P
)55P Q
;55Q R
}66 	
public88 
async88 
Task88 
<88 
HttpResponseMessage88 -
>88- .
GetAsync88/ 7
(887 8
string888 >
address88? F
)88F G
{99 	
if:: 
(:: 
string:: 
.:: 
IsNullOrWhiteSpace:: )
(::) *
address::* 1
)::1 2
)::2 3
throw;; 
new;; !
ArgumentNullException;; /
(;;/ 0
$str;;0 R
);;R S
;;;S T
_client<< 
.<< !
DefaultRequestHeaders<< )
.<<) *
Authorization<<* 7
=<<8 9
new<<: =%
AuthenticationHeaderValue<<> W
(<<W X
$str<<X _
,<<_ `
_account<<a i
.<<i j
Portal<<j p
.<<p q
ProgramToken<<q }
)<<} ~
;<<~ 
	_response== 
=== 
await== 
_client== %
.==% &
GetAsync==& .
(==. /
address==/ 6
)==6 7
;==7 8
return>> 
	_response>> 
;>> 
}?? 	
publicAA 
asyncAA 
TaskAA 
<AA 
HttpResponseMessageAA -
>AA- .
	PostAsyncAA/ 8
(AA8 9
stringAA9 ?
addressAA@ G
,AAG H
TAAI J
itemAAK O
)AAO P
{BB 	
ifCC 
(CC 
stringCC 
.CC 
IsNullOrWhiteSpaceCC )
(CC) *
addressCC* 1
)CC1 2
)CC2 3
throwDD 
newDD !
ArgumentNullExceptionDD /
(DD/ 0
$strDD0 R
)DDR S
;DDS T
SerializeContentEE 
(EE 
itemEE !
)EE! "
;EE" #
_clientFF 
.FF !
DefaultRequestHeadersFF )
.FF) *
AuthorizationFF* 7
=FF8 9
newFF: =%
AuthenticationHeaderValueFF> W
(FFW X
$strFFX _
,FF_ `
_accountFFa i
.FFi j
PortalFFj p
.FFp q
ProgramTokenFFq }
)FF} ~
;FF~ 
	_responseGG 
=GG 
awaitGG 
_clientGG %
.GG% &
	PostAsyncGG& /
(GG/ 0
addressGG0 7
,GG7 8
_contentGG9 A
)GGA B
;GGB C
returnHH 
	_responseHH 
;HH 
}II 	
publicKK 
asyncKK 
TaskKK 
<KK 
HttpResponseMessageKK -
>KK- .
PutAsyncKK/ 7
(KK7 8
stringKK8 >
addressKK? F
,KKF G
TKKH I
itemKKJ N
)KKN O
{LL 	
ifMM 
(MM 
stringMM 
.MM 
IsNullOrWhiteSpaceMM )
(MM) *
addressMM* 1
)MM1 2
)MM2 3
throwNN 
newNN !
ArgumentNullExceptionNN /
(NN/ 0
$strNN0 R
)NNR S
;NNS T
SerializeContentOO 
(OO 
itemOO !
)OO! "
;OO" #
_clientPP 
.PP !
DefaultRequestHeadersPP )
.PP) *
AuthorizationPP* 7
=PP8 9
newPP: =%
AuthenticationHeaderValuePP> W
(PPW X
$strPPX _
,PP_ `
_accountPPa i
.PPi j
PortalPPj p
.PPp q
ProgramTokenPPq }
)PP} ~
;PP~ 
	_responseQQ 
=QQ 
awaitQQ 
_clientQQ %
.QQ% &
PutAsyncQQ& .
(QQ. /
addressQQ/ 6
,QQ6 7
_contentQQ8 @
)QQ@ A
;QQA B
returnRR 
	_responseRR 
;RR 
}SS 	
}TT 
}UU ¬
|C:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Components\HyperWalletSenderSettings.cs
	namespace 	
HyperWalletLibrary
 
. 

Components '
{ 
public 

class %
HyperWalletSenderSettings *
<* +
T+ ,
>, -
:. /&
IHyperWalletSenderSettings0 J
<J K
TK L
>L M
whereN S
TT U
:V W
IHyperWalletModelX i
{ 
public 
HttpType 
Type 
{ 
get "
;" #
set$ '
;' (
}) *
=+ ,
HttpType- 5
.5 6
Get6 9
;9 :
public 
T 
Data 
{ 
get 
; 
set  
;  !
}" #
}		 
}

 Í
jC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Components\IGetter.cs
	namespace 	
HyperWalletLibrary
 
. 

Components '
{ 
public 

	interface *
IGetterFromHttpResponseMessage 3
<3 4
T4 5
>5 6
where7 <
T= >
:? @
IHyperWalletModelA R
{ 
HttpResponseMessage		 
Content		 #
{		$ %
get		& )
;		) *
set		+ .
;		. /
}		0 1
Task 
< 
T 
> 
GetAsync 
( 
) 
; 
} 
} ≥
vC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Components\IHyperWalletAccount.cs
	namespace 	
HyperWalletLibrary
 
. 

Components '
{ 
public 

	interface 
IHyperWalletAccount (
{ 
IHyperWalletProgram 
Main  
{! "
get# &
;& '
set( +
;+ ,
}- .
IHyperWalletProgram 
Card  
{! "
get# &
;& '
set( +
;+ ,
}- .
IHyperWalletProgram 
Direct "
{# $
get% (
;( )
set* -
;- .
}/ 0
IHyperWalletProgram 
Portal "
{# $
get% (
;( )
set* -
;- .
}/ 0
IHyperWalletProgram		 
Select		 "
{		# $
get		% (
;		( )
set		* -
;		- .
}		/ 0
}

 
} Ù
vC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Components\IHyperWalletProgram.cs
	namespace 	
HyperWalletLibrary
 
. 

Components '
{ 
public 

	interface 
IHyperWalletProgram (
{ 
string 
Username 
{ 
get 
; 
set "
;" #
}$ %
string 
Password 
{ 
get 
; 
set "
;" #
}$ %
string 
ProgramToken 
{ 
get !
;! "
set# &
;& '
}( )
} 
}		 £
uC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Components\IHyperWalletSender.cs
	namespace 	
HyperWalletLibrary
 
. 

Components '
{ 
public 

	interface 
IHyperWalletSender '
<' (
T( )
>) *
where+ 0
T1 2
:2 3
IHyperWalletModel4 E
{ 
Task		 
<		 
HttpResponseMessage		  
>		  !
	SendAsync		" +
(		+ ,
string		, 2
address		3 :
,		: ;&
IHyperWalletSenderSettings		< V
<		V W
T		W X
>		X Y
settings		Z b
)		b c
;		c d
Task

 
<

 
HttpResponseMessage

  
>

  !
GetAsync

" *
(

* +
string

+ 1
address

2 9
)

9 :
;

: ;
Task 
< 
HttpResponseMessage  
>  !
	PostAsync" +
(+ ,
string, 2
address3 :
,: ;
T< =
item> B
)B C
;C D
Task 
< 
HttpResponseMessage  
>  !
PutAsync" *
(* +
string+ 1
address2 9
,9 :
T; <
item= A
)A B
;B C
} 
} Ë
}C:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Components\IHyperWalletSenderSettings.cs
	namespace 	
HyperWalletLibrary
 
. 

Components '
{ 
public 

	interface &
IHyperWalletSenderSettings /
</ 0
T0 1
>1 2
where3 8
T9 :
:; <
IHyperWalletModel= N
{ 
HttpType 
Type 
{ 
get 
; 
set  
;  !
}" #
T 	
Data
 
{ 
get 
; 
set 
; 
} 
}		 
}

 Ê
eC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Model\Genders.cs
	namespace 	
HyperWalletLibrary
 
. 
Model "
{ 
public 

enum 
Genders 
{ 
MALE 
, 
FEMALE 
} 
} à
oC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Model\GovernmentIdTypes.cs
	namespace 	
HyperWalletLibrary
 
. 
Model "
{ 
public 

enum 
GovernmentIdTypes !
{ 
PASSPORT 
, 
NATIONAL_ID_CARD 
} 
} ˝
oC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Model\IHyperWalletModel.cs
	namespace 	
HyperWalletLibrary
 
. 
Model "
{ 
public 

	interface 
IHyperWalletModel &
{ 
List 
< 
Link 
> 
Links 
{ 
get 
; 
set  #
;# $
}% &
} 
}		 Â
bC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Model\Link.cs
	namespace 	
HyperWalletLibrary
 
. 
Model "
{ 
public 

class 
Link 
{ 
public 
LinkParametrs 
Params #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 
Href 
{ 
get  
;  !
set" %
;% &
}' (
} 
} ’
kC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Model\LinkParametrs.cs
	namespace 	
HyperWalletLibrary
 
. 
Model "
{ 
public 

class 
LinkParametrs 
{ 
public 
string 
Rel 
{ 
get 
;  
set! $
;$ %
}& '
} 
} ≈"
eC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Model\Payment.cs
[ 
assembly 	
:	 

InternalsVisibleTo 
( 
$str <
)< =
]= >
	namespace		 	
HyperWalletLibrary		
 
.		 
Model		 "
{

 
public 

class 
Payment 
: 
IHyperWalletModel ,
{ 
[ 	
JsonProperty	 
( 
$str 
) 
] 
public 
string 
Token 
{ 
get !
;! "
set# &
;& '
}( )
[ 	
JsonProperty	 
( 
$str 
) 
]  
[ 	
JsonConverter	 
( 
typeof 
( 
StringEnumConverter 1
)1 2
)2 3
]3 4
internal 
Status 
? 
Status 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
JsonProperty	 
( 
$str !
)! "
]" #
internal 
DateTime 
? 
	CreatedOn $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
JsonProperty	 
( 
$str 
) 
]  
public 
double 
Amount 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
JsonProperty	 
( 
$str '
)' (
]( )
public 
string 
ClientPaymentId %
{& '
get( +
;+ ,
internal- 5
set6 9
;9 :
}; <
[ 	
JsonProperty	 
( 
$str  
)  !
]! "
internal 
string 
Currency  
{! "
get# &
;& '
set( +
;+ ,
}- .
[ 	
JsonProperty	 
( 
$str (
)( )
]) *
public 
string 
DestinationToken &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
[ 	
JsonProperty	 
( 
$str !
)! "
]" #
public 
string 
	ExpiresOn 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
JsonProperty	 
( 
$str 
) 
] 
public 
string 
Memo 
{ 
get  
;  !
set" %
;% &
}' (
[   	
JsonProperty  	 
(   
$str   
)   
]   
public!! 
string!! 
Notes!! 
{!! 
get!! !
;!!! "
set!!# &
;!!& '
}!!( )
["" 	
JsonProperty""	 
("" 
$str"" $
)""$ %
]""% &
internal## 
string## 
ProgramToken## $
{##% &
get##' *
;##* +
set##, /
;##/ 0
}##1 2
[$$ 	
JsonProperty$$	 
($$ 
$str$$ 
)$$  
]$$  !
internal%% 
string%% 
Purpose%% 
{%%  !
get%%" %
;%%% &
set%%' *
;%%* +
}%%, -
[&& 	
JsonProperty&&	 
(&& 
$str&& !
)&&! "
]&&" #
public'' 
string'' 
	ReleaseOn'' 
{''  !
get''" %
;''% &
set''' *
;''* +
}'', -
[(( 	
JsonProperty((	 
((( 
$str(( 
)(( 
](( 
public)) 
List)) 
<)) 
Link)) 
>)) 
Links)) 
{))  !
get))" %
;))% &
set))' *
;))* +
})), -
}** 
}++ ı
qC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Model\PaymentModel\Status.cs
	namespace 	
HyperWalletLibrary
 
. 
Model "
." #
PaymentModel# /
{ 
enum 
Status	 
{ 
CREATED 
, 
	SCHEDULED 
, &
PENDING_ACCOUNT_ACTIVATION "
," #$
PENDING_TAX_VERIFICATION  
,  !*
PENDING_TRANSFER_METHOD_ACTION		 &
,		& ',
 PENDING_TRANSACTION_VERIFICATION

 (
,

( )
IN_PROGRESS 
, 
	COMPLETED 
, 
	CANCELLED 
, 
FAILED 
, 
RECALLED 
, 
RETURNED 
, 
EXPIRED 
} 
} ¯
jC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Model\ProfileTypes.cs
	namespace 	
HyperWalletLibrary
 
. 
Model "
{ 
public 

enum 
ProfileTypes 
{ 

INDIVIDUAL 
, 
BUSINESS 
} 
} ¥
fC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Model\Response.cs
	namespace 	
HyperWalletLibrary
 
. 
Model "
{ 
public 

class 
Response 
< 
T 
> 
: 
IHyperWalletModel 0
where1 6
T7 8
:9 :
IHyperWalletModel; L
{ 
[ 	
JsonProperty	 
( 
$str 
) 
] 
public		 
int		 
Count		 
{		 
get		 
;		 
set		  #
;		# $
}		% &
[

 	
JsonProperty

	 
(

 
$str

 
)

 
]

  
public 
int 
Offset 
{ 
get 
;  
set! $
;$ %
}& '
[ 	
JsonProperty	 
( 
$str 
) 
] 
public 
int 
Limit 
{ 
get 
; 
set  #
;# $
}% &
[ 	
JsonProperty	 
( 
$str 
) 
] 
public 
List 
< 
T 
> 
Data 
{ 
get !
;! "
set# &
;& '
}( )
[ 	
JsonProperty	 
( 
$str 
) 
] 
public 
List 
< 
Link 
> 
Links 
{  !
get" %
;% &
set' *
;* +
}, -
} 
} ¿I
bC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Model\User.cs
[ 
assembly 	
:	 

InternalsVisibleTo 
( 
$str <
)< =
]= >
	namespace		 	
HyperWalletLibrary		
 
.		 
Model		 "
{

 
public 

class 
User 
: 
IHyperWalletModel )
{ 
[ 	
JsonProperty	 
( 
$str 
) 
] 
public 
string 
Token 
{ 
get !
;! "
set# &
;& '
}( )
[ 	
JsonProperty	 
( 
$str 
) 
]  
[ 	
JsonConverter	 
( 
typeof 
( 
StringEnumConverter 1
)1 2
)2 3
]3 4
internal 
Status 
? 
Status 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
JsonProperty	 
( 
$str !
)! "
]" #
internal 
DateTime 
? 
	CreatedOn $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
JsonProperty	 
( 
$str $
)$ %
]% &
public 
string 
ClientUserId "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
JsonProperty	 
( 
$str $
)$ %
]% &
public 
string 
AddressLine1 "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
JsonProperty	 
( 
$str $
)$ %
]% &
public 
string 
AddressLine2 "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
JsonProperty	 
( 
$str 
) 
] 
public 
string 
City 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
JsonProperty	 
( 
$str 
)  
]  !
public 
string 
Country 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
JsonProperty	 
( 
$str &
)& '
]' (
public 
string 
CountryOfBirth $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[   	
JsonProperty  	 
(   
$str   ,
)  , -
]  - .
public!! 
string!!  
CountryOfNationality!! *
{!!+ ,
get!!- 0
;!!0 1
set!!2 5
;!!5 6
}!!7 8
["" 	
JsonProperty""	 
("" 
$str"" #
)""# $
]""$ %
public## 
DateTime## 
?## 
DateOfBirth## $
{##% &
get##' *
;##* +
set##, /
;##/ 0
}##1 2
[$$ 	
JsonProperty$$	 
($$ 
$str$$ (
)$$( )
]$$) *
public%% 
string%% 
DriversLicenseId%% &
{%%' (
get%%) ,
;%%, -
set%%. 1
;%%1 2
}%%3 4
[&& 	
JsonProperty&&	 
(&& 
$str&& 
)&& 
]&& 
public'' 
string'' 
Email'' 
{'' 
get'' !
;''! "
set''# &
;''& '
}''( )
[(( 	
JsonProperty((	 
((( 
$str(( "
)((" #
]((# $
public)) 
string)) 

EmployerId))  
{))! "
get))# &
;))& '
set))( +
;))+ ,
}))- .
[** 	
JsonProperty**	 
(** 
$str** !
)**! "
]**" #
public++ 
string++ 
	FirstName++ 
{++  !
get++" %
;++% &
set++' *
;++* +
}++, -
[,, 	
JsonProperty,,	 
(,, 
$str,, 
),, 
],,  
[-- 	
JsonConverter--	 
(-- 
typeof-- 
(-- 
StringEnumConverter-- 1
)--1 2
)--2 3
]--3 4
public.. 
Genders.. 
?.. 
Gender.. 
{..  
get..! $
;..$ %
set..& )
;..) *
}..+ ,
[// 	
JsonProperty//	 
(// 
$str// $
)//$ %
]//% &
public00 
string00 
GovernmentId00 "
{00# $
get00% (
;00( )
set00* -
;00- .
}00/ 0
[11 	
JsonProperty11	 
(11 
$str11 (
)11( )
]11) *
[22 	
JsonConverter22	 
(22 
typeof22 
(22 
StringEnumConverter22 1
)221 2
)222 3
]223 4
public33 
GovernmentIdTypes33  
?33  !
GovernmentIdType33" 2
{333 4
get335 8
;338 9
set33: =
;33= >
}33? @
[44 	
JsonProperty44	 
(44 
$str44  
)44  !
]44! "
public55 
string55 
Language55 
{55  
get55! $
;55$ %
set55& )
;55) *
}55+ ,
[66 	
JsonProperty66	 
(66 
$str66  
)66  !
]66! "
public77 
string77 
LastName77 
{77  
get77! $
;77$ %
set77& )
;77) *
}77+ ,
[88 	
JsonProperty88	 
(88 
$str88 "
)88" #
]88# $
public99 
string99 

MiddleName99  
{99! "
get99# &
;99& '
set99( +
;99+ ,
}99- .
[:: 	
JsonProperty::	 
(:: 
$str:: $
)::$ %
]::% &
public;; 
string;; 
MobileNumber;; "
{;;# $
get;;% (
;;;( )
set;;* -
;;;- .
};;/ 0
[<< 	
JsonProperty<<	 
(<< 
$str<< "
)<<" #
]<<# $
public== 
string== 

PassportId==  
{==! "
get==# &
;==& '
set==( +
;==+ ,
}==- .
[>> 	
JsonProperty>>	 
(>> 
$str>> #
)>># $
]>>$ %
public?? 
string?? 
PhoneNumber?? !
{??" #
get??$ '
;??' (
set??) ,
;??, -
}??. /
[@@ 	
JsonProperty@@	 
(@@ 
$str@@ "
)@@" #
]@@# $
publicAA 
stringAA 

PostalCodeAA  
{AA! "
getAA# &
;AA& '
setAA( +
;AA+ ,
}AA- .
[BB 	
JsonConverterBB	 
(BB 
typeofBB 
(BB 
StringEnumConverterBB 1
)BB1 2
)BB2 3
]BB3 4
[CC 	
JsonPropertyCC	 
(CC 
$strCC #
)CC# $
]CC$ %
internalDD 
ProfileTypesDD 
?DD 
ProfileTypeDD *
{DD+ ,
getDD- 0
;DD0 1
setDD2 5
;DD5 6
}DD7 8
[EE 	
JsonPropertyEE	 
(EE 
$strEE $
)EE$ %
]EE% &
internalFF 
stringFF 
ProgramTokenFF $
{FF% &
getFF' *
;FF* +
setFF, /
;FF/ 0
}FF1 2
[GG 	
JsonPropertyGG	 
(GG 
$strGG %
)GG% &
]GG& '
publicHH 
stringHH 
StateProvinceHH #
{HH$ %
getHH& )
;HH) *
setHH+ .
;HH. /
}HH0 1
[II 	
JsonConverterII	 
(II 
typeofII 
(II 
StringEnumConverterII 1
)II1 2
)II2 3
]II3 4
[JJ 	
JsonPropertyJJ	 
(JJ 
$strJJ *
)JJ* +
]JJ+ ,
publicKK 
VerificationStatusKK !
?KK! "
VerificationStatusKK# 5
{KK6 7
getKK8 ;
;KK; <
setKK= @
;KK@ A
}KKB C
[LL 	
JsonPropertyLL	 
(LL 
$strLL 
)LL 
]LL 
publicMM 
ListMM 
<MM 
LinkMM 
>MM 
LinksMM 
{MM  !
getMM" %
;MM% &
setMM' *
;MM* +
}MM, -
}NN 
}OO è
nC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Model\UserModel\Status.cs
	namespace 	
HyperWalletLibrary
 
. 
Model "
." #
	UserModel# ,
{ 
public 

enum 
Status 
{ 
PRE_ACTIVATED 
, 
	ACTIVATED 
, 
LOCKED 
, 
FROZEN 
, 
DE_ACTIVATED		 
}

 
} Ñ
zC:\Users\vlad1\source\repos\HyperWalletLibrary\HyperWalletLibrary\HyperWalletLibrary\Model\UserModel\VerificationStatus.cs
	namespace 	
HyperWalletLibrary
 
. 
Model "
." #
	UserModel# ,
{ 
public 

enum 
VerificationStatus "
{ 
NOT_REQUIRED 
, 
REQUIRED 
, 
UNDER_REVIEW 
, 
VERIFIED 
}		 
}

 