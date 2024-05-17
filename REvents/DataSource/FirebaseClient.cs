using Google.Cloud.Firestore;

namespace REvents.DataSource
{
    public class FirebaseClient
    {
        private FirestoreDb _instance;
        public FirestoreDb CreateDb()
        {
            return _instance ??= new FirestoreDbBuilder
            {
                ProjectId = "munich-affiche",
                JsonCredentials = @"{
  ""type"": ""service_account"",
  ""project_id"": ""munich-affiche"",
  ""private_key_id"": ""b0c5355742a84db772035aec951614e88e11edff"",
  ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQCuZ/T/rDCBIox0\nNzLbXx+gfPUnjcqRjkaDKN9vkRYXR5Hxul9IV/DHMjRdRtC7nHt5Zq8n/jN16qDB\n3xb1brkLk4qJm0u0ZJ25oDXWZyoGWE7nzKpkkWFiXkT/rUE6nRDRFmDJXM7tjv7r\nhLki0/3lgC/0D4scCbso607T/OPR5ckMOke5KyPCFaNogeX+ZCJEuKs4XDzMZVk0\ncnE+fjpkwcVtc+cth7JO9vgZUgWJ/kSb3+KEUZOz5Itci4UMb+L/aBqWWcrBDsSL\nRvx6OIZt3Reh0oyMJDBeTsI3sa9HevRtHQS/Hn9EoVprmCFIUEfGTvQQWe4vNMnU\n95KzLG0jAgMBAAECggEARwEg4ESAnNptd1UPufswu5yUDI3wFjFn6LcnvFrDtSeY\nteLMLv5KkzaP1hfiHDeZl3PkRLJ7zfp/h16lkLeK07k2Mk7M0/0Qr8WXlZn7pIio\nWzvadUYw8STzD2rAfzX55j4nmmNUBahthYJMA29uU1TMcR8w4fHeRksClVDEiavH\nhOXihlTwAleYy6PXTDzoVXSc3Bkqe9JK9Cos6J1xQ4yzFULKM7/ot7mNEmo/0xPe\no8dwgvgTBmAkCNi0d0pfcNDwjgKX6kfrHvMmnEpv3+9UhHA08Pw1T99N1ZdlWKUr\nvzuKJwhZOPe8S/v3wbmKGa9BObfbrHbCtFLMTk89NQKBgQDxk+XbeWI7KewH+tuH\nPBbFVsfAH1X9zvK9YzYGmkLgUrjah7vZZV0YOJbEKyCtg8ErZzfpUBHaE/N0ANTJ\nvBIO4mUSs/39/QxJA9T38vnHk9BVm9XmTDu10j9jMo1aSYWMTcy0BSni1i2Agyyd\n2rXnToFmX1RyMuDS6j/zo88q9wKBgQC40XSdGmUO9fRCbkWwrDQm/8mk9XADFMFZ\nc5JYfY1pTo2znjm9jkVqHODehhyPO9Ukm4ZJ4bb92lfHa6JDZl5eUpgpcSjKYfG5\n9UDx+QhVJM86UFuYNL0OIaY54BcFHvCrAfTDoGeogNiN4yPvVSmfPSloqntbFRyT\n5PNrOBG4NQKBgQCRDYQL92ODMNXXqMnd9reZgFTqSCaDApsAGq0a489aEHGMTcn+\na/2tCHWGjnrNlPoNDKomvnwpnKcmtUUPaIzTQR79TvQoaKPSx6k9xDg0nM2QScTy\nxj1oHDkRYA498z1sFF7gjOUsnfuuWZUVp3hnzdym0oDLHT+fhSYnLem72wKBgQC1\nkFeuiyKiqu/WXzypjtMBSSJQoynybO5xsT8hHd7RiHFe9t8koGMDFvG2yiu+bvo6\np2sqo8rA4kJ/z/atniCxKxT/CYMYJ1Zw6EZwMMWF186ZLB5/jbf47Qe/La2Pw1CN\nvzM1CB0thb64zV8dHR3xqQVIJMtgtIHJrQ+R0phdzQKBgHUfjpzWW2lIPi3PESrf\n+AKSTLNHt1HaHdnIxZnpBxPPqQCck0k2USV6sRsmt4jDu+bVMb2jqtT5+a2sU8ZR\n7yF4jJ0LR/2fe48LgdlCcoAdiDxZT9Qkjunn3YAV9l5bxck8dJ/kW8Dc0OhaTl/o\ni111PIVldPgOEXcdlLg7Z8Tj\n-----END PRIVATE KEY-----\n"",
  ""client_email"": ""firebase-adminsdk-25pcl@munich-affiche.iam.gserviceaccount.com"",
  ""client_id"": ""114853778683060951640"",
  ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
  ""token_uri"": ""https://oauth2.googleapis.com/token"",
  ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
  ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-25pcl%40munich-affiche.iam.gserviceaccount.com"",
  ""universe_domain"": ""googleapis.com""
}"
            }.Build();
        }
    }
}
