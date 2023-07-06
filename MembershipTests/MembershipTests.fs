module MembershipTests

open MembershipTypes
open MembershipFunctions
open Xunit

[<Fact>]
let ``Member subscribes to magazine`` () =
    let magazineSubscription = Magazine
    
    let memberSubscription = Subscribe magazineSubscription 
    
    Assert.Equal<MySubscriptions>(Magazine, memberSubscription)

