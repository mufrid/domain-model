module MembershipFunctions

open MembershipTypes

let Subscribe (subscription : MySubscriptions) =
    let memberSubscription = MemberSubscription subscription
    memberSubscription

