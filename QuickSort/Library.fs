namespace QuickSort

module QSort =
    let rec sort list =
        match list with
        | [] -> []
        | x :: list ->
            let smaller = sort (list |> List.filter(fun e -> e <= x))
            let bigger  = sort (list |> List.filter(fun e -> e >  x))
            smaller @ [x] @ bigger
