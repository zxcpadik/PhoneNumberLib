namespace PhoneNumberLib {
    public class PhoneNumber {
        public string snumber;
        public string cnumber;
        public bool valid;
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
