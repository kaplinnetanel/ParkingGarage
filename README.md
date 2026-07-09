[אפיון.מערכת לניהול רכבים :
המערכת פותחה לאפשרות של חניה ותיעוד ותשלום של כלי הרכב 
-	את המערכת חילקתי תחילה ל )Business Rule המערכת לניהול רכבים ,סוגי הרכבים תהתיעוד חישוב התשלום האפשרות לביצוע הזמנה מראש , ניהול ההזמנה, סיכום התשלום בדיקת אמינות חישוב התשלום ואפשרות לשנות את האמינות ע"פ הצורך  ) שהם אלו דברים ששייכים לבעיה עצמה לא לאופן הבניה הספציפי הזה .
ועוד דברים חילקתי ל Implementation Datail  (אופן התשלום, ניהול הזכרון) שבעצם שזה דברים שקשורים לבניה הנוכחית 
-	המערכת בנויה ע"פ הדרישה שניתנת להרחבה והוספה של עוד סוגים של כלי רכב שפשוט יצטרכו "להיות הבן" של המערכת לניהול רכבים (בשימוש של מחלקה האבא שהיא הבסיס מחלקה abstract)
-	
-	המערכת גם בנויה בצורה שהיא יכולה להשתנות באופן התשלום ע"פ בחירת הלקוח לכל סוג רכב .(אופן המימוש יהיה במחלקה abstract  של ניהול המערכת שבה כל סוג ככב יוכל לחשב את אופן התשלום שלו ע"פ שינויים תפעולים).
-	
-	המערכת יודעת להתמודד עם שינויים תפעוליים כמו שינוי האופציה של שמירה מקום מראש ונתינה הזכות לסוגים מסוימים וגם שינוי התשלום במחיר לכל סוג ולא נצטרך לשנות לכולם אלא אפשר יהיה ספציפי.(ע"פ אפשרות של interfase של אופן שמירת המקום מראש שמגיע יחודי למי שהגדירו שיכול להשתמש בה )
רכיבים מסוג של entity() : המערכת ניהול הרכבים(המערכת יודעת לבצע את הפעולה שלה בסיס משותף לכל הסוגים ) .                                                                                                       סוגי הרכבים(כל סוג של המערכת מקבל מחלקה משלו כי לכל אחד פעולה נתונים ויכולות שונות) . סיכום של כל סוג (מחזיק את התוצאות של כל סוג רכב של התשלום שלו )
רכיבים מסוג servise() :  חישבו התשלום(לכל סוג במערכת אופציה לבצע את התשלום ע"פ בחירה של הסוג הספציפי)
  הזמנה מראש (אפשרות של להזמין מראש חניה  )r
רכיבים מסוג work flow  לעדכן את הזיכרון (דואגת להכניס ולהוציאת את סוג הרכב מהחניה )
 בדיקת אמינות התונים   חישוב התשלום  (לפי הסוג האמינות והזמן)_
רכיבים מסוג של supporiting :הדפססה של הצלחה (יותר נכון שיחרור אחרי הצגת התשלום )
קבלת של אופן התתשלום (אופן שבו ישולם החניה)


ממשקים :
ממשק	שיטות
‏ISaveParking	‏void saveParking(SystemParking id,bool status)‏
‏Ipayment	‏void payment()‏
‏IReliability	‏bool reliability ( int  exit , int tict)‏
‏Icard	‏void card ( int ,number)‏


היררכיית המערכת (SystemManagement)

מחלקת הבסיס
Class	יורשת / מממשת	שדות + בנאי	Methods
SystemParking
t ‏ ‏(abstract)‏	—	‏public int timeEntering { get; }‏
‏public string  { get; }‏
‏protected Managerment(int,timeEnterin ,string status)‏

(	‏public abstract int Payment Calculation ()‏

מחלקות יורשות ממערכת הבסיס
Class	יורשת / מממשת	שדות + בנאי	Methods
‏RegularVehicles	‏: SystemParking
, ISaveParking‏	‏public bool save
public RegularVehicles (int,timeEnterin ,string status) : base(int,timeEnterin ,string status)‏	‏public override int Payment Calculation ()‏

‏public void save()‏
‏CarDisabledVehicles‏	:  SystemParking
, ISaveParking‏‏	‏public bool save  
public DisabledVehicles (int,timeEnterin ,string status) : base(int,timeEnterin ,string status)‏	public override int Payment Calculation ()‏

‏public void save()‏
CarMotorcycle ‏	‏:  SystemParking
‏	‏ public Motorcylce(int,timeEnterin ,string status) : base(int,timeEnterin ,string status)‏)‏	‏public override bool int Payment Calculation ()‏
‏


קלאס חדש של בדיקה ום של שמירה ג

Class	יורשת / מממשת	שדות + בנאי	Methods
‏ savingPayment	‏‏	 
public int timeExit { get; }‏
public 
(Managerment car,int timeExit):base(int,timeEnterin ,string status)‏

זורק ‏ArgumentException‏ אם ‏
Relaiability = false)	‏public bool reliability ( int  exit , int tict)‏
 Sumery 	:‏‏	‏ ‏
	
אופן התשלום
 (card)
Class	מממשת	Methods
‏Card	‏: Icard‏	‏public void card ( int ,number)‏
		‏

רצף ההרצה המלא (Main / composition root)
1.	‏Main‏  יוצא את הרכב המבוקש ומכניס אליו את כל הנתוני עפ בקשת הלקוח 
2.	כאשר הלקוח רוצה לצאת הבקשה הולכת לבדיקה עם הזמן המבוקש 
3.	כאש הבדקה מבוקשת הולכת לסיכום הסכום 
4.	ואופן התשלום מתבצע   על ידי תשלום של כארד שיכול להשתנות 



ocx
