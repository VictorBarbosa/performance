use chrono::prelude::*;
fn main() {
    let startTime: DateTime<Utc> = Utc::now();
    println!("Starttime {:#?}", startTime);
    counter();
    let endTime: DateTime<Utc> = Utc::now();
    println!("Starttime {:#?}", startTime);
    println!("EndTime {:#?}", endTime)
}
fn counter() {
    for i in 0..1000000 {
        println!("{:?}", i);
    }
}
