import java.io.*
import java.math.*
import java.text.*
import java.util.*
import java.util.regex.*

/*
 * Complete the connectingTowns function below.
 */
fun connectingTowns(n: Int, routes: Array<Int>): Int {
    /*
     * Write your code here.
     */
     var res = 1
     for(i in 0 until routes.size){
        res = (res * routes[i]) % 1234567
     }
     return res
}

fun main(args: Array<String>) {
    val scan = Scanner(System.`in`)

    val t = scan.nextLine().trim().toInt()

    for (tItr in 1..t) {
        val n = scan.nextLine().trim().toInt()

        val routes = scan.nextLine().split(" ").map{ it.trim().toInt() }.toTypedArray()

        val result = connectingTowns(n, routes)

        println(result)
    }
}
