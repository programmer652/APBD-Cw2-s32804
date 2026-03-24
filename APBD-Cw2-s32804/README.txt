W moim projekcie zaimplementowałem interfejs Iservice, który pozwala na zmianę kodu.
Zadbałem o kohezję we wszystkich klasach reprezentującyxh obiekty i osoby,
takich jak student, camera. zadbałem o coupling, na przykład nie korzystam osobnie z poosobnych equipment(takich jak camera, laptop)
w klasie service. zadbałem o odpowiedzialność clas, class service ospowiada za
obliczenie logiki o serwisise. Podzieliłem klasy po ich typom, na przykład 
wszystkie klasy equipment są w pliku equipment. jest wszystko sensownie
podzielono, jest dziedziczenie studenta i employee po user itp.