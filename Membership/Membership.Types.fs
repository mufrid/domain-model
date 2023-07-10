module MembershipTypes

type MySubscriptions = Magazine | Newsletter

type PersonalInformation = PersonalInformation of string
type UserName = UserName of string
type Password = Password of string
type Security = { UserName : UserName; Password : Password }
type MyProfile = { PersonalInformation : PersonalInformation; SecurityPreferences : Security }

type Invoice = Paid | Pending
type PaymentChannels = CreditCard | PayPal

type Member = { 
    Invoice : Invoice; 
    Payment : PaymentChannels; 
    MySubscriptions : MySubscriptions; 
    MyProfile : MyProfile 
    }

type PublishingFrequency = Monthly | Weekly 
type MemberSubscription = { Subscription : MySubscriptions; ReceivingSubscriptionFrequency : PublishingFrequency }




