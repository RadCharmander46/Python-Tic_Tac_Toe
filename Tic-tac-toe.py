import random
def hard_ai_evaluater(board,team,possible_wins):
    Xs = []
    Os = []
    for i in range(0,9):
        if board[i] == 1:
            Xs.append(i+1)
        elif board[i] == 2:
            Os.append(i+1)
    if team == 1:
        Opponents = Xs
        AIs = Os
    else:
        Opponents = Os
        AIs = Xs
        
    if len(AIs) == 0:
        return 5
    
    threating_moves = []
    for i in range(0,len(possible_wins)):
        opponent_icon = False
        ai_icon = []
        for i2 in range(0,3):
            if possible_wins[i][i2] in Opponents:
                opponent_icon = True
            elif possible_wins[i][i2] in AIs:
                ai_icon.append(i2)
        if len(ai_icon) == 1 and opponent_icon == False:
            if 0 in ai_icon:
                threating_moves.append(possible_wins[i][1])
                threating_moves.append(possible_wins[i][2])
            elif 1 in ai_icon:
                threating_moves.append(possible_wins[i][0])
                threating_moves.append(possible_wins[i][2])
            elif  2 in ai_icon:
                threating_moves.append(possible_wins[i][0])
                threating_moves.append(possible_wins[i][1])
    
    numbers = []
    for i in range(0,len(threating_moves)):
        for i2 in range(0,len(numbers)):
            if threating_moves[i] == numbers[i2]:
                return numbers[i2]
        numbers.append(threating_moves[i])
    return 69
def tie_checker(board):
    for i in range(0,len(board)):
        if board[i] == 0:
            return False
    return True
def can_win_checker(board,team,possible_wins,setting):
    Xs = []
    Os = []
    for i in range(0,9):
        if board[i] == 1:
            Xs.append(i+1)
        elif board[i] == 2:
            Os.append(i+1)
    if team == 1:
        Opponents = Xs
        AIs = Os
    else:
        Opponents = Os
        AIs = Xs
    for i in range(0,len(possible_wins)):
        opponent_icon = False
        ai_icon = []
        for i2 in range(0,3):
            if possible_wins[i][i2] in Opponents:
                opponent_icon = True
            elif possible_wins[i][i2] in AIs:
                ai_icon.append(i2)
        if len(ai_icon) == 2 and opponent_icon == False:
            if not 0 in ai_icon:
                return possible_wins[i][0]
            elif not 1 in ai_icon:
                return possible_wins[i][1]
            elif not 2 in ai_icon:
                return possible_wins[i][2]
    if setting > 2:
        for i in range(0,len(possible_wins)):
            ai_icons = False
            opponent_icons = []
            for i2 in range(0,3):
                if possible_wins[i][i2] in AIs:
                    ai_icons = True
                elif possible_wins[i][i2] in Opponents:
                    opponent_icons.append(i2)
            if len(opponent_icons) == 2 and ai_icons == False:
                if not 0 in opponent_icons:
                    return possible_wins[i][0]
                elif not 1 in opponent_icons:
                    return possible_wins[i][1]
                elif not 2 in opponent_icons:
                    return possible_wins[i][2]
    return 69
def turn_loop(board,team,difficulty):
    player = team
    board_image(board)
    while line_checker(board) == False and tie_checker(board) == False:
        if player == 1:
            player_turn(board,team)
            player = 2
        else:
            ai_turn(board,team,difficulty)
            player = 1
        print("")
        board_image(board)
    if tie_checker(board) == False:
        if player == 2:
            print("You won")
        else:
            print("You lost")
    else:
        print("You tied")
def line_checker(board):
    Xs = []
    Os = []
    Blanks = []
    for i in range(0,9):
        if board[i] == 1:
            Xs.append(i+1)
        elif board[i] == 2:
            Os.append(i+1)
    if 1 in Xs and 2 in Xs and 3 in Xs:
        return True
    elif 4 in Xs and 5 in Xs and 6 in Xs:
        return True
    elif 7 in Xs and 8 in Xs and 9 in Xs:
        return True
    elif 1 in Xs and 4 in Xs and 7 in Xs:
        return True
    elif 2 in Xs and 5 in Xs and 8 in Xs:
        return True
    elif 3 in Xs and 6 in Xs and 9 in Xs:
        return True
    elif 1 in Xs and 5 in Xs and 9 in Xs:
        return True
    elif 3 in Xs and 5 in Xs and 7 in Xs:
        return True
    elif 1 in Os and 2 in Os and 3 in Os:
        return True
    elif 4 in Os and 5 in Os and 6 in Os:
        return True
    elif 7 in Os and 8 in Os and 9 in Os:
        return True
    elif 1 in Os and 4 in Os and 7 in Os:
        return True
    elif 2 in Os and 5 in Os and 8 in Os:
        return True
    elif 3 in Os and 6 in Os and 9 in Os:
        return True
    elif 1 in Os and 5 in Os and 9 in Os:
        return True
    elif 3 in Os and 5 in Os and 7 in Os:
        return True
    else:
        return False
def player_turn(board,team):
    moving = True 
    while moving:
        move = int(input("Where do you want to go. 1-9 ")) -1
        if board[move] == 0:
            board[move] = team
            moving = False
        else:
            print("Invalid selection")
    return board
def ai_turn(board,team,difficulty):
    possible_wins = [[1,2,3],[4,5,6],[7,8,9],[1,4,7],[2,5,8],[3,6,9],[1,5,9],[3,5,7]]
    if team == 1:
        ai_team = 2
    else:
        ai_team = 1
    if difficulty == 1:
        moving = True 
        while moving:
            move = random.randint(0,8)
            if board[move] == 0:
                board[move] = ai_team
                moving = False
        return board
    if difficulty > 1:
        winning_move = can_win_checker(board,team,possible_wins,difficulty)
        if winning_move == 69:
            if difficulty < 4:
                moving = True 
                while moving:
                    move = random.randint(0,8)
                    if board[move] == 0:
                        print("test2")
                        board[move] = ai_team
                        moving = False
                return board
            else:
                winning_move = hard_ai_evaluater(board,team,possible_wins)
                if winning_move != 69:
                    board[winning_move-1] = ai_team
                    return board
                else:
                    moving = True 
                while moving:
                    move = random.randint(0,8)
                    if board[move] == 0:
                        print("test2")
                        board[move] = ai_team
                        moving = False
                return board
        else:
            board[winning_move-1] = ai_team
            return board
def board_image(board):
    line = ""
    for i in range(0,9):
        if board[i] == 0:
            line = line + " "
        elif board[i] == 1:
            line = line +"x"
        else:
            line = line + "o"
        
        if i % 3 == 2:
            print(line)
            line = ""
        else:
            line = line + "|"

def main():
    difficulty = 0
    turn = 1
    team = 0
    board = []
    for i in range(0,9):
        board.append(0)

    choosing = True
    while choosing:
        team_input = input("Xs or Os ")
        if team_input.lower() == "x" or team_input.lower() == "o":
            choosing = False
        else:
            print("Invalid selection")
    if team_input.lower() == "x":
        team = 1
    else:
        team = 2
    choosing = True
    while choosing:
        difficulty = int(input("What difficulty? Random,Easy,Medium or Hard. 1-4 "))
        if difficulty < 5 and difficulty > 0:
            choosing = False
        else:
            print("Invalid selection")

    turn_loop(board,team,difficulty)
main()