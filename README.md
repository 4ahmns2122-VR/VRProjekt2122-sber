# XRInteractionToolkitTemplate

### Project description: 
Story: Ein Geschwisterpaar ist in einem Labyrinth gefangen wobei das jüngere Geschwisterchen (Gj) vom älteren (Ga) herausgeführt werden muss. Der Spieler spielt Ga und muss 2 Puzzle lösen, um Gj zu finden und ein weiteres, um Gj herauszuführen. 
# Meilensteine: 
## 1.) 2.Dez.2021:

a. Movement (Teleportation)

b. 1. Puzzle

c. (optional) Partikel für Lawine 

d. (optional) Startbildschirm 

Movement und Puzzle 1 funktionieren die Lawine ist auch drin

## 2.) 23.Dez.2021: 
a. Bunsenbrenner-PickUp

b. Interaction mit Wand (optional mit Animation)

Bunsenbrenner wurde zu Fackel, Fackel interagiert mit Wand, Wand ist animiert

## 3.) 17.Feb.2022: 
a. Geschwisterchen folgt 

b. Audioimplementation

c. (optional) Endbildschirm

Geschwisterchen Puzzle wurde gekürzt (auf Befehl der Frau Prof.), Audio nicht komplett implementiert

# Audio: 
1.) Hilferufe (wegen Kürzung nicht möglich)

2.) Ambiance 

3.) Lawine 

4.) Schneeball Hit 

5.) Schneeball nehmen 

6.) Bunsenbrenner (wenn man die Wand schmilzt)/ Wand Schmilzt jetzt aufgrund von Änderung

# MVP: 
Audio, um Geschwisterchen zu lokalisieren (nicht möglich wegen Kürzung)

## Puzzle I (funktioniert):
werfbare Schneebälle, bei jedem Abschnitt, um einen zu werfen gibt es einen Schneehaufen mit unendlichem Vorrat

Bug mit dem der Schneeballhaufen zu viele Schneebälle erstellt

## Puzzle 2 (funktioniert):
es gibt im Labyrinth einen Bunsenbrenner mit welchen man sich durch eine Wand schmelzen muss. (Bunsenbrenner -> Fackel, jetzt mehrere Wände)

## Puzzle 3 (gekürzt):
man muss sein Geschwisterchen aus dem Labyrinth führen. 

# Arbeitsschritte: 
1.) GitHub Projekt

2.) Auf Plattform testen (.apk, Quest) 

3.) Whiteboxing 

4.) Schneebälle Modellieren 

5.) Schneeballhaufen 

6.) Schneebälle werfbare machen 

7.) Lawine löst sich 

8.) Testen (in VR) 

9.) Bunsenbrenner PickUp Modellieren 

10.) Bunsenbrenner PickUp Implementieren 

11.) Testen (in VR) 

12.) Geschwisterchen Modellieren (opt. Animieren) 

13.) Geschwisterchen Texturieren 

14.) Nav-Mesh (mit Jonathan) 

15.) Testen (in VR) 

16.) Audio Implementieren 

17.) Testen (in VR) 

18.) Texturen 

19.) Lighting 

20.) Abgabe


### Development platform: 
OS: Windows 10, Game Engine: Unity 2020.3.18f1, Visual Studio 2019, XR Interaction Toolkit

## Software/Hardware Requirements: 
Oculus hardware requirements https://support.oculus.com/248749509016567/
VR Headset benötigt, in diesem falle eine Oculus Rift/Quest/Quest2 

Nach dem herunterladen wird es einen Haufen Compilererorrors im Projekt. Um diese los zu werden, muss das XR interaction toolkit via den Package Manager installiert werden (!Preview Packages aktivieren)

### Target platform: 
Quest/2

### Visuals: 
Video in Assets showcase-video

### Third party material: 
Fürs testen ohne Headset, XR Device Simulatot verwenden (included in the xr interaction toolkit package):  https://www.youtube.com/watch?v=d4bTpkvBwrs
SFX: https://freesound.org
     https://youtu.be/cGoEkaYog7U
     https://youtu.be/_zDN_-5YG3g
     Script der Schmelzenden wand wurde von https://github.com/simoneliskases geschrieben

### Limitations/Problems: 

Copyright by Simon M. Berger
