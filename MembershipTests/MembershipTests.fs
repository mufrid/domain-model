module MembershipTests

open MembershipTypes
open MembershipFunctions
open Xunit

[<Fact>]
let ``Member subscribes to magazine and receives monthly subscription`` () =
    let magazineSubscription = Magazine
    let publishingFrequency = Monthly
    let expected = { Subscription = Magazine; ReceivingSubscriptionFrequency = Monthly }
    
    let actual = Subscribe magazineSubscription publishingFrequency 
    
    Assert.Equal<MemberSubscription>(expected, actual)
