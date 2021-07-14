using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_web.Models {

    public class CarClass {
        string color;
        int year;
        int hp;
        string name;
        string image;
        public CarClass(string c, string n, int y, int power) {
            color = c;
            name = n;
            year = y;
            hp = power;

        }
        public string getImage(){
            return image;
        }
        public void setImage(string img) {
            image = img;
        }
        public string getName() {
            return name;
        }
        public void setName(string n) {
            name = n;
        }
        public int getYear() {
            return year;
        }
        public void setYear(int y) {
            year = y;
        }
        public int getPower() {
            return hp;
        }
        public void setPower(int power) {
            hp = power;
        }
        public string getColor() {
            return color;
        }
        public void setColor(string c) {
            color = c;
        }
        public override string ToString() {
            return name+" "+color+" "+year.ToString()+" "+hp.ToString();
        }
    }
    
}
