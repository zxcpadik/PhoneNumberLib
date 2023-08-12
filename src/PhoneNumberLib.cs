namespace PhoneNumberLib {
    public class PhoneNumber {
        /// <summary>
        /// Phone number from input
        /// </summary>
        public string snumber { get; private set; }
        /// <summary>
        /// Normalized phone number
        /// </summary>
        public string cnumber { get; private set; }
        public bool valid { get; private set; }

        /// <summary>
        /// Accepts a string with a number then clears and normalizes it
        /// </summary>
        /// <param name="snumber">String with the number to convert</param>
        public PhoneNumber(string snumber) {
            this.snumber = snumber;
            cnumber = "";

            if (!ContainOnlyPhoneChars(snumber)) { valid = false; return; }

            cnumber = "";
            for (int i = 0; i < snumber.Length; i++) {
                char ch = snumber[i];
                if (char.IsNumber(ch) || ch == '+') cnumber += ch;
            }
            if (!cnumber.StartsWith("+")) cnumber = cnumber.Insert(0, "+");
        }

        public override string ToString() {
            return cnumber;
        }
        public override int GetHashCode() {
            return cnumber.GetHashCode(); 
        }
        public override bool Equals(object obj) {
            return this.GetHashCode() == obj.GetHashCode();
        }

        public static bool ContainOnlyPhoneChars(string s) {
            if (s.Length < 11) return false;
            if (string.IsNullOrEmpty(s)) return false;
            for (int i = 0; i < s.Length; i++) {
                char ch = s[i];
                if (!(char.IsDigit(ch) || ch == '+' || ch == '(' || ch == ')' || ch == '-' || ch == ' ')) return false;
            }
            return true;
        }
    }
}
