import java.io.*
import java.math.*
import java.text.*
import java.util.*
import java.util.regex.*

/*
 * Complete the halloweenParty function below.
 */
fun halloweenParty(k: Int): Long {
    /*
     * Write your code here.
     */
     return (k / 2).toLong() * (k - k/2)
}

fun main(args: Array<String>) {
    val scan = Scanner(System.`in`)

    val t = scan.nextLine().trim().toInt()

    for (tItr in 1..t) {
        val k = scan.nextLine().trim().toInt()

        val result = halloweenParty(k)

        println(result)
    }
}
