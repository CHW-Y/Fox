## 필독

`예시`

![image](https://user-images.githubusercontent.com/86601932/130741073-d8449320-a424-40a4-8dbf-a49e030c3050.png)

`Assets > Scenes` 경로에 각자 이름으로된 Scene을 추가하여 작업 해주시길 바랍니다.




## 필요 데이터

`로그인`
아이디,비밀번호

기초 데이터 [엑셀데이터]
음식 : [종류][타입(SP,친밀도)][수치]
상호작용: [타입(SP,친밀도)][수치]

`위치` - 데이터 로드 위치지정(기본값)
현재 GPS경로위치
지정한 GPS위치 배열List<>

`스타일변경` - 데이터 로드 스타일 지정 (기본값)
스타일 -> 프리팹
캐릭터 프리팹 string이름 : 스타일프리팹 string이름

`스탯`
친밀도
스테미너

(아이디에 맞춰서 따로 저장)
`데이터 저장` -> `데이터 로드`
## 엑셀데이터
https://docs.google.com/spreadsheets/d/1kw1idAXUs6IIm9lJ_auKIDLpd9fCFW-rk9o-eL4GMAQ/edit?usp=sharing
## 엑셀 다운로드 방법
![image](https://user-images.githubusercontent.com/33707494/131534324-45d92cbc-b021-4ccc-98c7-f770b59f76f1.png)

- Add Sheet Name통해서 원하는 시트 이름으로 찾을 수 있음
- 그냥 Download data하면 전체 시트 불러옴


## 엑셀 데이터 링크
https://docs.google.com/spreadsheets/d/1kw1idAXUs6IIm9lJ_auKIDLpd9fCFW-rk9o-eL4GMAQ/edit?usp=sharing
아마 권한이 없을텐데 권한요청을 따로 말씀해주세요.

## Google sheet to Json
https://assetstore.unity.com/packages/tools/utilities/google-sheet-to-json-90369
에셋을 설치해야 사용이 가능합니다.
![image](https://user-images.githubusercontent.com/33707494/131981668-87ffe6a3-2342-48a5-a4d9-ffc78cb092db.png)
밑줄친 파일은 제외하고 임포트 해주세요.

## Google Data 사용 방법.
GlobalState에서 각 데이터 List를 참조해 올 수 있습니다.
<pre>
<code>
public class GlobalState : MonoBehaviour
{
    public static List<ExceldData_Item> itemList;
    public static List<ExceldData_Style> styleList;
    public static List<ExceldData_Character> characterList;
    public static List<ExceldData_Gesture> gestureList;

    public static Dictionary<string, ExceldData_Item> itemDict;
    public static Dictionary<string, ExceldData_Style> styleDict;
    public static Dictionary<string, ExceldData_Character> charaterDict;
    public static Dictionary<string, ExceldData_Gesture> gestureDict;
}
</code>
<pre>

### 방법 예시

