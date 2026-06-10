# 02-NumberWizard-tschimmerl

Markdown Cheatsheet: https://github.com/adam-p/markdown-here/wiki/markdown-cheatsheet

# Number Wizard UI

Ein interaktives Zahlen-Ratespiel entwickelt in Unity, bei dem der Computer versucht, eine vom Spieler erdachte Zahl zu erraten.

## Ziel des Spiels
Der Spieler denkt sich eine Zahl in einem festgelegten Bereich (Standard: 1 bis 100). Der "Number Wizard" (die KI des Spiels) gibt Tipps ab. Der Spieler gibt dem System über Buttons Feedback, ob die gesuchte Zahl höher oder niedriger ist, bis der Computer die richtige Zahl erraten hat.

## Bedienung & Buttons
Das Spiel wird komplett über die Benutzeroberfläche gesteuert:
* **Higher:** Klicke diesen Button, wenn deine ausgedachte Zahl *höher* ist als der aktuelle Tipp des Computers.
* **Lower:** Klicke diesen Button, wenn deine ausgedachte Zahl *niedriger* ist als der aktuelle Tipp des Computers.
* **Correct:** Klicke diesen Button, wenn der Computer deine Zahl *exakt erraten* hat. Das Spiel wird damit erfolgreich beendet.
* **Restart:** Erscheint nach einem Sieg und setzt das Spiel auf die Startwerte zurück, um eine neue Runde zu beginnen.

## Die Algorithmus: Binäre Suche
Das Spiel nutzt das Prinzip der **binären Suche** (Binary Search), um die Zahl so schnell wie möglich zu erraten. Bei jedem Klick auf *Higher* oder *Lower* wird der Suchbereich halbiert. 
Um Rundungsfehler bei den Grenzwerten (z. B. das Erreichen der Zahl 100) im Integer-Bereich von Unity zu verhindern, wird die mathematisch optimierte Formel verwendet:
`guess = (min + max + 1) / 2;`

## Technische Details
* **Unity-Version:** 2022.3.20f1  * **Startszene:** Assets/MyGame/Scenes/Sandbox.unity ```

---

### 📝 3. Der Git-Commit für Issue 9

Wenn du die Datei gespeichert hast, öffnest du deine Git Bash und tippst die vorgegebene Commit-Message ein:

```bash
git add README.md
git commit -m "docs: add README for number wizard"
