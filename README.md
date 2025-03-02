Zasady utworzenia projektu z programowania obiektowego 

1. Technologie i środowisko 
o Projekt musi być napisany w języku C# w środowisku konsoli. 
o Wykorzystaj platformę .NET 8 / .NET 9

3. Konstrukcja projektu 
o Programowanie obiektowe (OOP): 
 Zaimplementuj przynajmniej trzy klasy reprezentujące różne elementy logiki 
projektu. 
 Wykorzystaj dziedziczenie: jedna klasa bazowa oraz minimum dwie klasy 
dziedziczące. 
 Zaimplementuj interfejs i co najmniej jedną klasę go implementującą. 
o Delegaty i zdarzenia: 
 Stwórz delegat(y) i wykorzystaj je do obsługi logiki programu. 
 Zaimplementuj zdarzenia związane z akcjami wykonywanymi przez 
użytkownika (np. udane logowanie, zmiana hasła, zapis do pliku logów).

5. Funkcjonalność projektu 
o System logowania (RBAC – Role-Based Access Control): 
 Użytkownik loguje się do systemu podając login i hasło. 
 Dane logowania muszą być odczytywane z zewnętrznego pliku tekstowego 
(np. users.txt). 
 W systemie muszą być zaimplementowane role (np. Admin, User), które 
definiują uprawnienia użytkownika. 
o Logika programu: 
 Po zalogowaniu użytkownik uzyskuje dostęp do funkcji zależnych od swojej 
roli (np. administrator może modyfikować dane, użytkownik – jedynie je 
przeglądać). 
o Obsługa wyjątków: 
 Zaimplementuj obsługę wyjątków (np. błąd w odczycie pliku, nieprawidłowy 
format danych, próba zalogowania nieistniejącego użytkownika).

7. Struktura kodu 
o Podziel kod na moduły (np. klasy odpowiedzialne za logowanie, zarządzanie 
użytkownikami, obsługę zdarzeń). 
o Użyj czytelnych nazw metod i zmiennych, zgodnych z konwencjami C#. 
o Wykorzystaj komentarze w kodzie do wyjaśnienia bardziej złożonych fragmentów.

9. Pliki wejściowe/wyjściowe 
o Plik z użytkownikami (users.txt): 
 Format danych: 
o W trakcie działania programu możesz zapisywać logi akcji użytkowników do pliku (np. 
logs.txt).

11. Testowanie i demonstracja 
o Zaimplementuj prosty mechanizm testowania logowania i uprawnień. 
o Przygotuj zestaw przykładowych danych do pliku users.txt (np. co najmniej dwóch 
użytkowników z różnymi rolami). 
o Upewnij się, że każda funkcjonalność programu działa poprawnie i zgodnie z 
założeniami.

13. Termin i forma oddania projektu 
o Zgłoś projekt w formie spakowanego archiwum ZIP, zawierającego: 
 Plik .sln oraz cały folder projektu. 
 Pliki wejściowe (users.txt i inne, jeśli są potrzebne). 
 Plik README.md z krótkim opisem funkcjonalności i instrukcją uruchomienia 
programu.

15. Kryteria oceny 
o Poprawność działania programu. 
o Zastosowanie wszystkich wymaganych elementów (klasy, dziedziczenie, interfejsy, 
delegaty, zdarzenia, system logowania RBAC). 
o Czytelność i organizacja kodu. 
o Obsługa błędów i wyjątków. 
